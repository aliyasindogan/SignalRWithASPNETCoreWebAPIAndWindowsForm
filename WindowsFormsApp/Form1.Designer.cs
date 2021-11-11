
namespace WindowsFormsApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weatherForecastsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // weatherForecastsList
            // 
            this.weatherForecastsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherForecastsList.FormattingEnabled = true;
            this.weatherForecastsList.Location = new System.Drawing.Point(0, 0);
            this.weatherForecastsList.Name = "weatherForecastsList";
            this.weatherForecastsList.Size = new System.Drawing.Size(725, 355);
            this.weatherForecastsList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 355);
            this.Controls.Add(this.weatherForecastsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SignalR With ASP.NET Core WebAPI And Windows Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox weatherForecastsList;
    }
}

