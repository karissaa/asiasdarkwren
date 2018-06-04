namespace AsiasDarkWren
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.away = new System.Windows.Forms.Button();
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.username_text = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.Label();
            this.gradient_panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.round_corner = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passWord = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.drag_control = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            this.gradient_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // away
            // 
            this.away.BackColor = System.Drawing.Color.White;
            this.away.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.away.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.away.FlatAppearance.BorderSize = 0;
            this.away.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.away.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.away.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.away.Image = global::AsiasDarkWren.Properties.Resources.cancel;
            this.away.Location = new System.Drawing.Point(727, 12);
            this.away.Name = "away";
            this.away.Size = new System.Drawing.Size(24, 24);
            this.away.TabIndex = 0;
            this.away.UseVisualStyleBackColor = false;
            this.away.Click += new System.EventHandler(this.away_Click);
            // 
            // slidePic
            // 
            this.slidePic.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidePic.Image = ((System.Drawing.Image)(resources.GetObject("slidePic.Image")));
            this.slidePic.Location = new System.Drawing.Point(0, 0);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(350, 500);
            this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidePic.TabIndex = 1;
            this.slidePic.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_text.Location = new System.Drawing.Point(400, 170);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(108, 23);
            this.username_text.TabIndex = 5;
            this.username_text.Text = "Username";
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(400, 270);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(103, 23);
            this.password_text.TabIndex = 6;
            this.password_text.Text = "Password";
            // 
            // gradient_panel
            // 
            this.gradient_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradient_panel.BackgroundImage")));
            this.gradient_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradient_panel.Controls.Add(this.label1);
            this.gradient_panel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.gradient_panel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
            this.gradient_panel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
            this.gradient_panel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.gradient_panel.Location = new System.Drawing.Point(0, 446);
            this.gradient_panel.Name = "gradient_panel";
            this.gradient_panel.Quality = 10;
            this.gradient_panel.Size = new System.Drawing.Size(350, 54);
            this.gradient_panel.TabIndex = 7;
            // 
            // btn_Login
            // 
            this.btn_Login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Login.BorderRadius = 3;
            this.btn_Login.ButtonText = "Sign In";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Login.Iconimage = null;
            this.btn_Login.Iconimage_right = null;
            this.btn_Login.Iconimage_right_Selected = null;
            this.btn_Login.Iconimage_Selected = null;
            this.btn_Login.IconMarginLeft = 0;
            this.btn_Login.IconMarginRight = 0;
            this.btn_Login.IconRightVisible = true;
            this.btn_Login.IconRightZoom = 0D;
            this.btn_Login.IconVisible = true;
            this.btn_Login.IconZoom = 90D;
            this.btn_Login.IsTab = false;
            this.btn_Login.Location = new System.Drawing.Point(547, 400);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
            this.btn_Login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Login.selected = false;
            this.btn_Login.Size = new System.Drawing.Size(153, 50);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "Sign In";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Textcolor = System.Drawing.Color.White;
            this.btn_Login.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // round_corner
            // 
            this.round_corner.ElipseRadius = 10;
            this.round_corner.TargetControl = this;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Window;
            this.userName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
            this.userName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.userName.BorderThickness = 3;
            this.userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userName.isPassword = false;
            this.userName.Location = new System.Drawing.Point(400, 200);
            this.userName.Margin = new System.Windows.Forms.Padding(4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(300, 44);
            this.userName.TabIndex = 8;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passWord
            // 
            this.passWord.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(183)))));
            this.passWord.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passWord.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(229)))), ((int)(((byte)(151)))));
            this.passWord.BorderThickness = 3;
            this.passWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passWord.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passWord.isPassword = true;
            this.passWord.Location = new System.Drawing.Point(400, 300);
            this.passWord.Margin = new System.Windows.Forms.Padding(4);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(300, 44);
            this.passWord.TabIndex = 9;
            this.passWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // drag_control
            // 
            this.drag_control.Fixed = true;
            this.drag_control.Horizontal = true;
            this.drag_control.TargetControl = this;
            this.drag_control.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "www.AsiasDarkWren.com";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.away;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.gradient_panel);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.slidePic);
            this.Controls.Add(this.away);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hospitality";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainkeys);
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            this.gradient_panel.ResumeLayout(false);
            this.gradient_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button away;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label username_text;
        private System.Windows.Forms.Label password_text;
        private Bunifu.Framework.UI.BunifuGradientPanel gradient_panel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Login;
        private Bunifu.Framework.UI.BunifuElipse round_corner;
        private Bunifu.Framework.UI.BunifuMetroTextbox passWord;
        private Bunifu.Framework.UI.BunifuMetroTextbox userName;
        private Bunifu.Framework.UI.BunifuDragControl drag_control;
        private System.Windows.Forms.Label label1;
    }
}