
namespace EasyTable.Forms.GenericForms
{
    partial class ConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textLbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnYes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.header1 = new EasyTable.Forms.Controls.Header();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuPanel1.BorderRadius = 15;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.header1);
            this.bunifuPanel1.Controls.Add(this.textLbl);
            this.bunifuPanel1.Controls.Add(this.btnYes);
            this.bunifuPanel1.Controls.Add(this.btnNo);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(390, 214);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // textLbl
            // 
            this.textLbl.AllowParentOverrides = false;
            this.textLbl.AutoEllipsis = false;
            this.textLbl.AutoSize = false;
            this.textLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.textLbl.CursorType = System.Windows.Forms.Cursors.Default;
            this.textLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLbl.ForeColor = System.Drawing.Color.White;
            this.textLbl.Location = new System.Drawing.Point(23, 49);
            this.textLbl.Name = "textLbl";
            this.textLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textLbl.Size = new System.Drawing.Size(345, 74);
            this.textLbl.TabIndex = 34;
            this.textLbl.Text = "Сигурни ли сте, че искате да продължите?";
            this.textLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.textLbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnYes
            // 
            this.btnYes.AllowAnimations = true;
            this.btnYes.AllowMouseEffects = true;
            this.btnYes.AllowToggling = false;
            this.btnYes.AnimationSpeed = 200;
            this.btnYes.AutoGenerateColors = false;
            this.btnYes.AutoRoundBorders = false;
            this.btnYes.AutoSizeLeftIcon = true;
            this.btnYes.AutoSizeRightIcon = true;
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.ButtonText = "Запази";
            this.btnYes.ButtonTextMarginLeft = 0;
            this.btnYes.ColorContrastOnClick = 45;
            this.btnYes.ColorContrastOnHover = 45;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnYes.CustomizableEdges = borderEdges1;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnYes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnYes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnYes.IconMarginLeft = 11;
            this.btnYes.IconPadding = 10;
            this.btnYes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnYes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnYes.IconSize = 25;
            this.btnYes.IdleBorderColor = System.Drawing.Color.LightGray;
            this.btnYes.IdleBorderRadius = 10;
            this.btnYes.IdleBorderThickness = 1;
            this.btnYes.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnYes.IdleIconLeftImage = null;
            this.btnYes.IdleIconRightImage = null;
            this.btnYes.IndicateFocus = false;
            this.btnYes.Location = new System.Drawing.Point(218, 135);
            this.btnYes.Name = "btnYes";
            this.btnYes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYes.OnDisabledState.BorderRadius = 10;
            this.btnYes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnDisabledState.BorderThickness = 1;
            this.btnYes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYes.OnDisabledState.IconLeftImage = null;
            this.btnYes.OnDisabledState.IconRightImage = null;
            this.btnYes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnYes.onHoverState.BorderRadius = 10;
            this.btnYes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.onHoverState.BorderThickness = 1;
            this.btnYes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnYes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnYes.onHoverState.IconLeftImage = null;
            this.btnYes.onHoverState.IconRightImage = null;
            this.btnYes.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnYes.OnIdleState.BorderRadius = 10;
            this.btnYes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnIdleState.BorderThickness = 1;
            this.btnYes.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnYes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnYes.OnIdleState.IconLeftImage = null;
            this.btnYes.OnIdleState.IconRightImage = null;
            this.btnYes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnYes.OnPressedState.BorderRadius = 10;
            this.btnYes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnPressedState.BorderThickness = 1;
            this.btnYes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnYes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnYes.OnPressedState.IconLeftImage = null;
            this.btnYes.OnPressedState.IconRightImage = null;
            this.btnYes.Size = new System.Drawing.Size(150, 39);
            this.btnYes.TabIndex = 33;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnYes.TextMarginLeft = 0;
            this.btnYes.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnYes.UseDefaultRadiusAndThickness = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.AllowAnimations = true;
            this.btnNo.AllowMouseEffects = true;
            this.btnNo.AllowToggling = false;
            this.btnNo.AnimationSpeed = 200;
            this.btnNo.AutoGenerateColors = false;
            this.btnNo.AutoRoundBorders = false;
            this.btnNo.AutoSizeLeftIcon = true;
            this.btnNo.AutoSizeRightIcon = true;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.ButtonText = "Отказ";
            this.btnNo.ButtonTextMarginLeft = 0;
            this.btnNo.ColorContrastOnClick = 45;
            this.btnNo.ColorContrastOnHover = 45;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNo.CustomizableEdges = borderEdges2;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNo.IconMarginLeft = 11;
            this.btnNo.IconPadding = 10;
            this.btnNo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNo.IconSize = 25;
            this.btnNo.IdleBorderColor = System.Drawing.Color.LightGray;
            this.btnNo.IdleBorderRadius = 10;
            this.btnNo.IdleBorderThickness = 1;
            this.btnNo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnNo.IdleIconLeftImage = null;
            this.btnNo.IdleIconRightImage = null;
            this.btnNo.IndicateFocus = false;
            this.btnNo.Location = new System.Drawing.Point(23, 135);
            this.btnNo.Name = "btnNo";
            this.btnNo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNo.OnDisabledState.BorderRadius = 10;
            this.btnNo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnDisabledState.BorderThickness = 1;
            this.btnNo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNo.OnDisabledState.IconLeftImage = null;
            this.btnNo.OnDisabledState.IconRightImage = null;
            this.btnNo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNo.onHoverState.BorderRadius = 10;
            this.btnNo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.onHoverState.BorderThickness = 1;
            this.btnNo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNo.onHoverState.IconLeftImage = null;
            this.btnNo.onHoverState.IconRightImage = null;
            this.btnNo.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnNo.OnIdleState.BorderRadius = 10;
            this.btnNo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnIdleState.BorderThickness = 1;
            this.btnNo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnNo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNo.OnIdleState.IconLeftImage = null;
            this.btnNo.OnIdleState.IconRightImage = null;
            this.btnNo.OnPressedState.BorderColor = System.Drawing.Color.LightGray;
            this.btnNo.OnPressedState.BorderRadius = 10;
            this.btnNo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnPressedState.BorderThickness = 1;
            this.btnNo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.btnNo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNo.OnPressedState.IconLeftImage = null;
            this.btnNo.OnPressedState.IconRightImage = null;
            this.btnNo.Size = new System.Drawing.Size(150, 39);
            this.btnNo.TabIndex = 32;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNo.TextMarginLeft = 0;
            this.btnNo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNo.UseDefaultRadiusAndThickness = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.header1.Location = new System.Drawing.Point(3, 3);
            this.header1.Name = "header1";
            this.header1.ShowMinimizeButton = false;
            this.header1.ShowResizeButton = false;
            this.header1.Size = new System.Drawing.Size(384, 40);
            this.header1.TabIndex = 35;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(390, 214);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmationForm";
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Controls.Header header1;
        private Bunifu.UI.WinForms.BunifuLabel textLbl;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}