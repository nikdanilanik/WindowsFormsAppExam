namespace WindowsFormsAppExam.Forms
{
    partial class AddRepairRequest
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
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTypeEquipment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProblemDesc = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(139, 10);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(173, 20);
            this.textBoxItemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Что требует ремонта?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип неисправности";
            // 
            // textBoxTypeEquipment
            // 
            this.textBoxTypeEquipment.Location = new System.Drawing.Point(139, 36);
            this.textBoxTypeEquipment.Name = "textBoxTypeEquipment";
            this.textBoxTypeEquipment.Size = new System.Drawing.Size(173, 20);
            this.textBoxTypeEquipment.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "id клиента";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(139, 62);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(173, 20);
            this.textBoxClientId.TabIndex = 4;
            this.textBoxClientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientId_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Описание проблемы";
            // 
            // textBoxProblemDesc
            // 
            this.textBoxProblemDesc.Location = new System.Drawing.Point(139, 88);
            this.textBoxProblemDesc.Multiline = true;
            this.textBoxProblemDesc.Name = "textBoxProblemDesc";
            this.textBoxProblemDesc.Size = new System.Drawing.Size(173, 156);
            this.textBoxProblemDesc.TabIndex = 6;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(198, 250);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(114, 23);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Создать заявку";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 250);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Отменить создание";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AddRepairRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 279);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProblemDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTypeEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxItemName);
            this.Name = "AddRepairRequest";
            this.Text = "Добавление заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTypeEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProblemDesc;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonClose;
    }
}