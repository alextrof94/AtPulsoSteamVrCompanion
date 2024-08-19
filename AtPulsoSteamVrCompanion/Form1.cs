using Newtonsoft.Json;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using Valve.VR;

namespace AtPulsoSteamVrCompanion
{
    public partial class Form1 : Form
    {
        readonly static string AppVersion = "1.0.1";
        readonly static string AppName = "AtPulseSteamVrCompanion";
        readonly static string AppNameSnake = "at_pulse_vr_companion";
        readonly string PathToExe = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
        List<Preset> Presets = new List<Preset>();
        Preset SelectedPreset;
        bool AppStarted = false;

        string LastBPM = "--";

        // Overlay
        bool VrStarted = false;
        bool GlStarted = false;
        ulong OverlayHandle = 0;
        CVRSystem? VrSystem = null;
        uint HmdId;
        uint LeftHandId;
        uint RightHandId;
        private GameWindow FakeGameWindow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            CbDevice.Items.Clear();
            CbDevice.Items.AddRange(Translations.GetString("Devices").Split('|'));

            if (File.Exists(PathToExe + "Presets.json"))
                Presets = JsonConvert.DeserializeObject<List<Preset>>(File.ReadAllText(PathToExe + "Presets.json"));
            else
                Presets = new List<Preset>() { new Preset() { Name = "1" }, new Preset() { Name = "2" }, new Preset() { Name = "3" } };

            CbPreset.Items.Clear();
            CbPreset.Items.AddRange(Presets.ToArray());
            if (Properties.Settings.Default.PresetIndex < CbPreset.Items.Count)
                CbPreset.SelectedIndex = Properties.Settings.Default.PresetIndex;
            SelectedPreset = (Preset)CbPreset.SelectedItem;
            UpdatePresetUI();

            TbApAddress.Text = Properties.Settings.Default.ApAddress;
            CbToTray.Checked = Properties.Settings.Default.ToTray;
            CbMinimize.Checked = Properties.Settings.Default.AutoHide;
            CbStartWithSteamVR.Checked = Properties.Settings.Default.AutoStart;

            if (CbMinimize.Checked)
            {
                WindowState = FormWindowState.Minimized;
            }

            AppStarted = true;
            TryToInitVr();
        }

        private void TiCheckVr_Tick(object sender, EventArgs e)
        {
            if (!AppStarted) return;
            TryToInitVr();
        }

        private string DoGetRequest(string url)
        {
            string res = "";
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(delegate { return true; });
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            httpWebRequest.Timeout = 100;

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                res = streamReader.ReadToEnd();
            }
            return res;
        }

        private async Task GetPulse()
        {
            try
            {
                LastBPM = DoGetRequest(TbApAddress.Text + "getpulse/");
                this.Invoke(new Action(() =>
                {
                    BuHr.Text = LastBPM;
                    BuHr.BackColor = Color.LightGreen;
                    RenderVr();
                }));
            }
            catch
            {
                this.Invoke(new Action(() =>
                {
                    LastBPM = "--";
                    BuHr.Text = LastBPM;
                    BuHr.BackColor = Color.LightPink;
                    RenderVr();
                }));
            }
        }

        private void TiGetPulse_Tick(object sender, EventArgs e)
        {
            if (!AppStarted) return;
            if (string.IsNullOrEmpty(TbApAddress.Text))
                return;

            var t = GetPulse();
        }

        private void CbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!AppStarted) return;
            if (CbPreset.SelectedIndex < 0)
                return;
            Properties.Settings.Default.PresetIndex = CbPreset.SelectedIndex;
            Properties.Settings.Default.Save();

            SelectedPreset = (Preset)CbPreset.SelectedItem;

            UpdatePresetUI();
        }

        private void UpdatePresetUI()
        {
            NudSize.Value = SelectedPreset.Size;
            NudOpacity.Value = SelectedPreset.Opacity;
            NudX.Value = SelectedPreset.X;
            NudY.Value = SelectedPreset.Y;
            NudZ.Value = SelectedPreset.Z;
            NudPitch.Value = SelectedPreset.Pitch;
            NudYaw.Value = SelectedPreset.Yaw;
            NudRoll.Value = SelectedPreset.Roll;

            CbDevice.SelectedIndex = SelectedPreset.DeviceId;
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            if (nud.Name == "NudSize")
                SelectedPreset.Size = nud.Value;
            if (nud.Name == "NudOpacity")
                SelectedPreset.Opacity = nud.Value;
            if (nud.Name == "NudX")
                SelectedPreset.X = nud.Value;
            if (nud.Name == "NudY")
                SelectedPreset.Y = nud.Value;
            if (nud.Name == "NudZ")
                SelectedPreset.Z = nud.Value;
            if (nud.Name == "NudPitch")
                SelectedPreset.Pitch = nud.Value;
            if (nud.Name == "NudYaw")
                SelectedPreset.Yaw = nud.Value;
            if (nud.Name == "NudRoll")
                SelectedPreset.Roll = nud.Value;
            UpdateVrUI();
        }

        private void BuPresetSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(PathToExe + "Presets.json", JsonConvert.SerializeObject(Presets));
        }

        private void CbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!AppStarted) return;
            if (CbDevice.SelectedIndex < 0)
                return;
            SelectedPreset.DeviceId = CbDevice.SelectedIndex;
            UpdateVrUI();
        }

        private void TbApAddress_TextChanged(object sender, EventArgs e)
        {
            if (!AppStarted) return;
            Properties.Settings.Default.ApAddress = TbApAddress.Text;
            Properties.Settings.Default.Save();
        }

        private void CbStartWithSteamVR_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppStarted) return;

            if (!VrStarted)
            {
                if (CbStartWithSteamVR.Checked)
                    CbStartWithSteamVR.Checked = false;
                return;
            }
            Properties.Settings.Default.AutoStart = CbStartWithSteamVR.Checked;
            Properties.Settings.Default.Save();

            if (CbStartWithSteamVR.Checked)
            {
                if (!OpenVR.Applications.IsApplicationInstalled(AppName))
                {
                    var manifestError = OpenVR.Applications.AddApplicationManifest(Path.GetFullPath(PathToExe + "app.vrmanifest"), false);
                    if (manifestError == EVRApplicationError.None)
                    {
                        OpenVR.Applications.SetApplicationAutoLaunch(AppName, true);
                    }
                }
            }
            else
            {
                if (OpenVR.Applications.IsApplicationInstalled(AppName))
                {
                    OpenVR.Applications.SetApplicationAutoLaunch(AppName, false);
                    Thread.Sleep(100);
                    OpenVR.Applications.RemoveApplicationManifest(Path.GetFullPath(PathToExe + "app.vrmanifest"));
                }
            }
        }

        private void CbMinimize_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppStarted) return;
            Properties.Settings.Default.AutoHide = CbMinimize.Checked;
            Properties.Settings.Default.Save();
        }

        private void CbToTray_CheckedChanged(object sender, EventArgs e)
        {
            if (!AppStarted) return;
            Properties.Settings.Default.ToTray = CbToTray.Checked;
            Properties.Settings.Default.Save();
        }

        private void NiMain_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Activate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (CbToTray.Checked)
                {
                    Hide();
                    ShowInTaskbar = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VrStarted)
            {
                OpenVR.Overlay.DestroyOverlay(OverlayHandle);
                FakeGameWindow.Close();
                FakeGameWindow.Dispose();
            }
            NiMain.Visible = false;
            NiMain.Dispose();
        }



        void InitGL()
        {
            GameWindowSettings gwSettings = new GameWindowSettings() { };
            NativeWindowSettings nwSettings = new NativeWindowSettings()
            {
                Size = new OpenTK.Mathematics.Vector2i(300, 150),
                Title = "VrScreamer Preview",
                //StartVisible = false,
                WindowBorder = OpenTK.Windowing.Common.WindowBorder.Hidden,
                Location = new OpenTK.Mathematics.Vector2i(-10000, -10000)
            };
            FakeGameWindow = new GameWindow(gwSettings, nwSettings) { IsVisible = false };


            GL.ClearColor(new Color4(0.1f, 0, 0, 0.5f));

            //// Create and compile shaders
            //int vertexShader = LoadShader(ShaderType.VertexShader, pathToExe + "vertex_shader.glsl");

            //int fragmentShader = LoadShader(ShaderType.FragmentShader, pathToExe + "fragment_shader.glsl");

            //// Create shader program
            //shaderProgram = GL.CreateProgram();
            //GL.AttachShader(shaderProgram, vertexShader);

            //GL.AttachShader(shaderProgram, fragmentShader);

            //GL.LinkProgram(shaderProgram);

            //GL.DetachShader(shaderProgram, vertexShader);
            //GL.DetachShader(shaderProgram, fragmentShader);
            //GL.DeleteShader(vertexShader);
            //GL.DeleteShader(fragmentShader);

            //// Create vertex array and vertex buffer objects
            //GL.GenVertexArrays(1, out vertexArrayObject);
            //GL.BindVertexArray(vertexArrayObject);

            //GL.GenBuffers(1, out vertexBufferObject);
            //GL.BindBuffer(BufferTarget.ArrayBuffer, vertexBufferObject);

            //// Define the vertices of a quad
            //float[] vertices = {
            //    -1.0f, -1.0f, 0.0f, 1.0f, 1.0f,
            //    1.0f, -1.0f, 0.0f, 0.0f, 1.0f,
            //    1.0f,  1.0f, 0.0f, 0.0f, 0.0f,
            //    -1.0f, -1.0f, 0.0f, 1.0f, 1.0f,
            //    1.0f,  1.0f, 0.0f, 0.0f, 0.0f,
            //    -1.0f,  1.0f, 0.0f, 1.0f, 0.0f
            //};

            //GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

            //// Specify vertex attributes
            //int vertexPositionLocation = GL.GetAttribLocation(shaderProgram, "aPosition");

            //int vertexTexCoordLocation = GL.GetAttribLocation(shaderProgram, "aTexCoord");

            //GL.EnableVertexAttribArray(vertexPositionLocation);

            //GL.VertexAttribPointer(vertexPositionLocation, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);

            //GL.EnableVertexAttribArray(vertexTexCoordLocation);

            //GL.VertexAttribPointer(vertexTexCoordLocation, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

            //GL.UseProgram(shaderProgram);
            //GL.BindVertexArray(vertexArrayObject);
        }

        static void WriteToBitmap(Bitmap bmp, string text, Color color)
        {
            using (var graphics = Graphics.FromImage(bmp))
            {
                using (var brush = new SolidBrush(color))
                {
                    // Clear the texture with a transparent color
                    //graphics.Clear(Color.Transparent);

                    Font font = new Font(FontFamily.GenericSansSerif, 100, FontStyle.Bold);
                    StringFormat stringFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    var imgPadding = new Rectangle(0, 0, bmp.Width, bmp.Height);


                    // Set text rendering options
                    graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                    graphics.DrawString(text, font, brush, imgPadding, stringFormat);
                }
            }
        }

        int LoadTexture(string imagePath)
        {
            int textureId = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, textureId);

            // Load the image using System.Drawing
            Bitmap bitmap = new Bitmap(imagePath);
            WriteToBitmap(bitmap, LastBPM, Color.White);
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);


            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D,
                0,
                PixelInternalFormat.Rgba,
                data.Width,
                data.Height,
                0,
                OpenTK.Graphics.OpenGL4.PixelFormat.Bgra,
                PixelType.UnsignedByte,
                data.Scan0);

            bitmap.UnlockBits(data);
            bitmap.Dispose();

            // Set texture parameters (optional)
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

            return textureId;
        }

        private void RenderVr()
        {
            int TextureId = LoadTexture(PathToExe + "AtPulsoSteamVrCompanion_Background.png");

            Texture_t texture = new Texture_t();
            texture.eColorSpace = EColorSpace.Auto;
            texture.eType = ETextureType.OpenGL;
            texture.handle = (IntPtr)TextureId;
            OpenVR.Overlay.SetOverlayTexture(OverlayHandle, ref texture);

            GL.DeleteTextures(1, ref TextureId);
        }

        private void UpdateVrUI()
        {
            if (!VrStarted) return;
            OpenVR.Overlay.SetOverlayWidthInMeters(OverlayHandle, (float)SelectedPreset.Size);

            OpenVR.Overlay.SetOverlayAlpha(OverlayHandle, (float)SelectedPreset.Opacity);


            uint[] indexes = new uint[1];
            VrSystem.GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass.HMD, indexes, 0);
            HmdId = indexes[0];
            LeftHandId = VrSystem.GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole.LeftHand);
            RightHandId = VrSystem.GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole.RightHand);

            if (LeftHandId > 0 && LeftHandId < 256)
            {
                BuVrL.BackColor = Color.LightGreen;
                if (SelectedPreset.DeviceId == 1)
                    AssociateOverlayToDevice(OverlayHandle, LeftHandId);
            }
            else
                BuVrL.BackColor = Color.LightPink;

            if (RightHandId > 0 && RightHandId < 256)
            {
                BuVrR.BackColor = Color.LightGreen;
                if (SelectedPreset.DeviceId == 2)
                    AssociateOverlayToDevice(OverlayHandle, RightHandId);
            }
            else
                BuVrR.BackColor = Color.LightPink;

            if (SelectedPreset.DeviceId == 0)
                AssociateOverlayToDevice(OverlayHandle, HmdId);


        }

        bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        void AssociateOverlayToDevice(ulong overlayHandle, uint deviceIndex)
        {

            float rollAngle = (float)((float)SelectedPreset.Roll * (Math.PI / 180.0));
            float rollCosAngle = (float)Math.Cos(rollAngle);
            float rollSinAngle = (float)Math.Sin(rollAngle);
            HmdMatrix34_t rollMatrix = new HmdMatrix34_t()
            {
                m0 = rollCosAngle,
                m1 = rollSinAngle,
                m4 = -rollSinAngle,
                m5 = rollCosAngle,
                m10 = 1
            };

            float pitchAngle = (float)((float)SelectedPreset.Pitch * (Math.PI / 180.0));
            float pitchCosAngle = (float)Math.Cos(pitchAngle);
            float pitchSinAngle = (float)Math.Sin(pitchAngle);
            HmdMatrix34_t pitchMatrix = new HmdMatrix34_t()
            {
                m0 = 1,
                m5 = pitchCosAngle,
                m6 = pitchSinAngle,
                m9 = -pitchSinAngle,
                m10 = pitchCosAngle
            };

            float yawAngle = (float)((float)SelectedPreset.Yaw * (Math.PI / 180.0));
            float yawCosAngle = (float)Math.Cos(yawAngle);
            float yawSinAngle = (float)Math.Sin(yawAngle);
            HmdMatrix34_t yawMatrix = new HmdMatrix34_t()
            {
                m0 = yawCosAngle,
                m2 = -yawSinAngle,
                m5 = 1,
                m8 = yawSinAngle,
                m10 = yawCosAngle
            };

            HmdMatrix34_t defaultTransform = new HmdMatrix34_t()
            {
                m0 = -1,
                m5 = -1,
                m10 = 1
            };

            HmdMatrix34_t rotatedTransform = MultiplyMatrices(MultiplyMatrices(MultiplyMatrices(defaultTransform, yawMatrix), pitchMatrix), rollMatrix);
            rotatedTransform.m3 += (float)SelectedPreset.X;
            rotatedTransform.m7 += (float)SelectedPreset.Y;
            rotatedTransform.m11 -= (float)SelectedPreset.Z;

            OpenVR.Overlay.SetOverlayTransformTrackedDeviceRelative(overlayHandle, deviceIndex, ref rotatedTransform);
        }

        private HmdMatrix34_t MultiplyMatrices(HmdMatrix34_t matrix1, HmdMatrix34_t matrix2)
        {
            HmdMatrix34_t result = new HmdMatrix34_t();

            result.m0 = matrix1.m0 * matrix2.m0 + matrix1.m4 * matrix2.m1 + matrix1.m8 * matrix2.m2;
            result.m1 = matrix1.m1 * matrix2.m0 + matrix1.m5 * matrix2.m1 + matrix1.m9 * matrix2.m2;
            result.m2 = matrix1.m2 * matrix2.m0 + matrix1.m6 * matrix2.m1 + matrix1.m10 * matrix2.m2;
            result.m3 = matrix1.m3 * matrix2.m0 + matrix1.m7 * matrix2.m1 + matrix1.m11 * matrix2.m2 + matrix2.m3;

            result.m4 = matrix1.m0 * matrix2.m4 + matrix1.m4 * matrix2.m5 + matrix1.m8 * matrix2.m6;
            result.m5 = matrix1.m1 * matrix2.m4 + matrix1.m5 * matrix2.m5 + matrix1.m9 * matrix2.m6;
            result.m6 = matrix1.m2 * matrix2.m4 + matrix1.m6 * matrix2.m5 + matrix1.m10 * matrix2.m6;
            result.m7 = matrix1.m3 * matrix2.m4 + matrix1.m7 * matrix2.m5 + matrix1.m11 * matrix2.m6 + matrix2.m7;

            result.m8 = matrix1.m0 * matrix2.m8 + matrix1.m4 * matrix2.m9 + matrix1.m8 * matrix2.m10;
            result.m9 = matrix1.m1 * matrix2.m8 + matrix1.m5 * matrix2.m9 + matrix1.m9 * matrix2.m10;
            result.m10 = matrix1.m2 * matrix2.m8 + matrix1.m6 * matrix2.m9 + matrix1.m10 * matrix2.m10;
            result.m11 = matrix1.m3 * matrix2.m8 + matrix1.m7 * matrix2.m9 + matrix1.m11 * matrix2.m10 + matrix2.m11;
            return result;
        }
        bool InitVr()
        {
            if (!IsProcessRunning("vrserver") && !IsProcessRunning("vrcompositor"))
                return false;

            if (!VrStarted)
            {
                OverlayHandle = 0;
                var systemErr = EVRInitError.None;
                VrSystem = OpenVR.Init(ref systemErr, EVRApplicationType.VRApplication_Overlay);
                if (systemErr != EVRInitError.None)
                    return false;

                EVROverlayError overlayErr = OpenVR.Overlay.CreateOverlay(AppNameSnake, AppName, ref OverlayHandle);
                if (overlayErr != EVROverlayError.None)
                {
                    if (overlayErr == EVROverlayError.KeyInUse)
                    {
                        OpenVR.Overlay.FindOverlay(AppNameSnake, ref OverlayHandle);
                        OpenVR.Overlay.DestroyOverlay(OverlayHandle);
                    }
                    return false;
                }

                OpenVR.Overlay.SetOverlayAlpha(OverlayHandle, 0);
                OpenVR.Overlay.SetOverlayColor(OverlayHandle, 1, 1, 1);
                OpenVR.Overlay.ShowOverlay(OverlayHandle);

                VRTextureBounds_t bounds;
                bounds.uMin = 0;
                bounds.uMax = 1;
                bounds.vMin = 0;
                bounds.vMax = 1;
                OpenVR.Overlay.SetOverlayTextureBounds(OverlayHandle, ref bounds);

                BuVrStatus.BackColor = Color.LightGreen;
            }

            UpdateVrUI();
            return true;
        }

        private void CheckingForExitSteamVr()
        {
            while (VrStarted)
            {
                var vrEvents = new List<VREvent_t>();
                var vrEvent = new VREvent_t();
                uint eventSize = (uint)Marshal.SizeOf(vrEvent);
                try
                {
                    while (OpenVR.System.PollNextEvent(ref vrEvent, eventSize))
                    {
                        vrEvents.Add(vrEvent);
                    }
                }
                catch
                {
                }

                foreach (var e in vrEvents)
                {
                    if ((EVREventType)e.eventType == EVREventType.VREvent_Quit)
                    {
                        OpenVR.System.AcknowledgeQuit_Exiting();
                        VrStarted = false;
                        this.Invoke(new Action(() =>
                        {
                            this.Close();
                        }));
                    }
                }
                Thread.Sleep(100);
            }
        }

        void TryToInitVr()
        {
            VrStarted = InitVr();
            if (VrStarted)
            {

                Task t = new(() =>
                {
                    CheckingForExitSteamVr();
                });
                t.Start();
                if (!GlStarted)
                    InitGL();
                GlStarted = true;
            }
            CbStartWithSteamVR.Enabled = VrStarted;
        }

        private void BuAdjust_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string tag = (string)button.Tag;
            string[] p = tag.Split(',');

            NumericUpDown? target = null;
            decimal changeValue = 0;

            switch (p[0])
            {
                case "S": target = NudSize; changeValue = (decimal)0.1; break;
                case "O": target = NudOpacity; changeValue = (decimal)0.1; break;
                case "X": target = NudX; changeValue = (decimal)0.1; break;
                case "Y": target = NudY; changeValue = (decimal)0.1; break;
                case "Z": target = NudZ; changeValue = (decimal)0.1; break;
                case "P": target = NudPitch; changeValue = (decimal)10; break;
                case "Yaw": target = NudYaw; changeValue = (decimal)10; break;
                case "R": target = NudRoll; changeValue = (decimal)10; break;
            }
            if (target == null)
                return;

            switch (p[1])
            {
                case "--": changeValue *= (decimal)-0.1; break;
                case "-": changeValue *= (decimal)-1; break;
                case "+": changeValue *= (decimal)1; break;
                case "++": changeValue *= (decimal)0.1; break;
            }

            if (changeValue < 0 && target.Value + changeValue >= target.Minimum)
                target.Value += changeValue;
            if (changeValue > 0 && target.Value + changeValue <= target.Maximum)
                target.Value += changeValue;
        }

    }
}