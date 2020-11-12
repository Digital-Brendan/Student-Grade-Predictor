namespace StudentGradePredictor
{
    partial class frm_loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loading));
            this.pbox_logo = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pbar_loading = new System.Windows.Forms.ProgressBar();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_logo
            // 
            this.pbox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pbox_logo.Image")));
            this.pbox_logo.Location = new System.Drawing.Point(97, 37);
            this.pbox_logo.Name = "pbox_logo";
            this.pbox_logo.Size = new System.Drawing.Size(300, 300);
            this.pbox_logo.TabIndex = 0;
            this.pbox_logo.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_name.Location = new System.Drawing.Point(183, 452);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(134, 16);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Brendan Rogan 2020";
            // 
            // pbar_loading
            // 
            this.pbar_loading.ForeColor = System.Drawing.Color.Green;
            this.pbar_loading.Location = new System.Drawing.Point(172, 378);
            this.pbar_loading.Name = "pbar_loading";
            this.pbar_loading.Size = new System.Drawing.Size(154, 23);
            this.pbar_loading.TabIndex = 2;
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.Location = new System.Drawing.Point(225, 362);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(54, 13);
            this.lbl_loading.TabIndex = 3;
            this.lbl_loading.Text = "Loading...";
            // 
            // timer_loading
            // 
            this.timer_loading.Tick += new System.EventHandler(this.timer_loading_Tick);
            // 
            // frm_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 477);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.pbar_loading);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pbox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grade Predictor";
            this.Load += new System.EventHandler(this.frm_loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_logo;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ProgressBar pbar_loading;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Timer timer_loading;
    }
}