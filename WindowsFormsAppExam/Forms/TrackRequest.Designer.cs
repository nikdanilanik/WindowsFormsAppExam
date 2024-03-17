namespace WindowsFormsAppExam.Forms
{
    partial class TrackRequest
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
            this.textBoxStatusRequest = new System.Windows.Forms.TextBox();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.textBoxRequestId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxStatusRequest
            // 
            this.textBoxStatusRequest.Location = new System.Drawing.Point(43, 6);
            this.textBoxStatusRequest.Name = "textBoxStatusRequest";
            this.textBoxStatusRequest.ReadOnly = true;
            this.textBoxStatusRequest.Size = new System.Drawing.Size(103, 20);
            this.textBoxStatusRequest.TabIndex = 0;
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.Location = new System.Drawing.Point(152, 6);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(75, 21);
            this.buttonUpdateStatus.TabIndex = 1;
            this.buttonUpdateStatus.Text = "Обновить";
            this.buttonUpdateStatus.UseVisualStyleBackColor = true;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.buttonUpdateStatus_Click);
            // 
            // textBoxRequestId
            // 
            this.textBoxRequestId.Location = new System.Drawing.Point(4, 6);
            this.textBoxRequestId.Name = "textBoxRequestId";
            this.textBoxRequestId.Size = new System.Drawing.Size(33, 20);
            this.textBoxRequestId.TabIndex = 2;
            this.textBoxRequestId.Text = "id";
            this.textBoxRequestId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRequestId.Enter += new System.EventHandler(this.textBoxRequestId_Enter);
            this.textBoxRequestId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStatusRequest_KeyPress);
            this.textBoxRequestId.Leave += new System.EventHandler(this.textBoxRequestId_Leave);
            // 
            // TrackRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 31);
            this.Controls.Add(this.textBoxRequestId);
            this.Controls.Add(this.buttonUpdateStatus);
            this.Controls.Add(this.textBoxStatusRequest);
            this.Name = "TrackRequest";
            this.Text = "Отслеживание заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStatusRequest;
        private System.Windows.Forms.Button buttonUpdateStatus;
        private System.Windows.Forms.TextBox textBoxRequestId;
    }
}