namespace RIT_Automation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelLng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3126, 194);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(575, 575);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            // 
            // gMapControl2
            // 
            this.gMapControl2.Bearing = 0F;
            this.gMapControl2.CanDragMap = true;
            this.gMapControl2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl2.GrayScaleMode = false;
            this.gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl2.LevelsKeepInMemory = 5;
            this.gMapControl2.Location = new System.Drawing.Point(12, 12);
            this.gMapControl2.MarkersEnabled = true;
            this.gMapControl2.MaxZoom = 2;
            this.gMapControl2.MinZoom = 2;
            this.gMapControl2.MouseWheelZoomEnabled = true;
            this.gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl2.Name = "gMapControl2";
            this.gMapControl2.NegativeMode = false;
            this.gMapControl2.PolygonsEnabled = true;
            this.gMapControl2.RetryLoadTile = 0;
            this.gMapControl2.RoutesEnabled = true;
            this.gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl2.ShowTileGridLines = false;
            this.gMapControl2.Size = new System.Drawing.Size(970, 482);
            this.gMapControl2.TabIndex = 2;
            this.gMapControl2.Zoom = 0D;
            this.gMapControl2.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.Map_Zoom_pic);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Lime;
            this.buttonGreen.Location = new System.Drawing.Point(991, 18);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(111, 203);
            this.buttonGreen.TabIndex = 3;
            this.buttonGreen.Text = "Добавить зеленый маркер";
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(988, 283);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(111, 211);
            this.buttonRed.TabIndex = 4;
            this.buttonRed.Text = "Добавить красный маркер";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(988, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 22);
            this.textBox1.TabIndex = 5;
            // 
            // labelLat
            // 
            this.labelLat.Location = new System.Drawing.Point(424, 497);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(406, 25);
            this.labelLat.TabIndex = 7;
            this.labelLat.Text = "Lat";
            // 
            // labelLng
            // 
            this.labelLng.Location = new System.Drawing.Point(424, 533);
            this.labelLng.Name = "labelLng";
            this.labelLng.Size = new System.Drawing.Size(406, 25);
            this.labelLng.TabIndex = 8;
            this.labelLng.Text = "Lng";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lat";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lat";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(988, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zoom";
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.ClientSize = new System.Drawing.Size(1109, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLng);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.gMapControl2);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label labelLng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

