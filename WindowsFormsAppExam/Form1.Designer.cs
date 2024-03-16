namespace WindowsFormsAppExam
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
            this.createDefaultRepos = new System.Windows.Forms.Button();
            this.deleteDefaultRepos = new System.Windows.Forms.Button();
            this.buttonRequestAdd = new System.Windows.Forms.Button();
            this.buttonClientAdd = new System.Windows.Forms.Button();
            this.buttonFindClintByPhoneNumber = new System.Windows.Forms.Button();
            this.buttonUpdateRequest = new System.Windows.Forms.Button();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.buttonListClients = new System.Windows.Forms.Button();
            this.buttonListRequests = new System.Windows.Forms.Button();
            this.buttonListUsers = new System.Windows.Forms.Button();
            this.buttonTrackRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDefaultRepos
            // 
            this.createDefaultRepos.Location = new System.Drawing.Point(654, 415);
            this.createDefaultRepos.Name = "createDefaultRepos";
            this.createDefaultRepos.Size = new System.Drawing.Size(134, 23);
            this.createDefaultRepos.TabIndex = 0;
            this.createDefaultRepos.Text = "Создать таблицы в БД";
            this.createDefaultRepos.UseVisualStyleBackColor = true;
            this.createDefaultRepos.Click += new System.EventHandler(this.createDefaultRepos_Click);
            // 
            // deleteDefaultRepos
            // 
            this.deleteDefaultRepos.Location = new System.Drawing.Point(514, 415);
            this.deleteDefaultRepos.Name = "deleteDefaultRepos";
            this.deleteDefaultRepos.Size = new System.Drawing.Size(134, 23);
            this.deleteDefaultRepos.TabIndex = 1;
            this.deleteDefaultRepos.Text = "Удалить таблицы в БД";
            this.deleteDefaultRepos.UseVisualStyleBackColor = true;
            this.deleteDefaultRepos.Click += new System.EventHandler(this.deleteDefaultRepos_Click);
            // 
            // buttonRequestAdd
            // 
            this.buttonRequestAdd.Location = new System.Drawing.Point(12, 13);
            this.buttonRequestAdd.Name = "buttonRequestAdd";
            this.buttonRequestAdd.Size = new System.Drawing.Size(136, 23);
            this.buttonRequestAdd.TabIndex = 2;
            this.buttonRequestAdd.Text = "Добавить заявку";
            this.buttonRequestAdd.UseVisualStyleBackColor = true;
            this.buttonRequestAdd.Click += new System.EventHandler(this.buttonRequestAdd_Click);
            // 
            // buttonClientAdd
            // 
            this.buttonClientAdd.Location = new System.Drawing.Point(154, 13);
            this.buttonClientAdd.Name = "buttonClientAdd";
            this.buttonClientAdd.Size = new System.Drawing.Size(136, 23);
            this.buttonClientAdd.TabIndex = 3;
            this.buttonClientAdd.Text = "Добавить клиента";
            this.buttonClientAdd.UseVisualStyleBackColor = true;
            this.buttonClientAdd.Click += new System.EventHandler(this.buttonClientAdd_Click);
            // 
            // buttonFindClintByPhoneNumber
            // 
            this.buttonFindClintByPhoneNumber.Location = new System.Drawing.Point(654, 12);
            this.buttonFindClintByPhoneNumber.Name = "buttonFindClintByPhoneNumber";
            this.buttonFindClintByPhoneNumber.Size = new System.Drawing.Size(134, 34);
            this.buttonFindClintByPhoneNumber.TabIndex = 4;
            this.buttonFindClintByPhoneNumber.Text = "Найти id клиента по номеру телефона";
            this.buttonFindClintByPhoneNumber.UseVisualStyleBackColor = true;
            this.buttonFindClintByPhoneNumber.Click += new System.EventHandler(this.buttonFindClintByPhoneNumber_Click);
            // 
            // buttonUpdateRequest
            // 
            this.buttonUpdateRequest.Location = new System.Drawing.Point(12, 42);
            this.buttonUpdateRequest.Name = "buttonUpdateRequest";
            this.buttonUpdateRequest.Size = new System.Drawing.Size(136, 23);
            this.buttonUpdateRequest.TabIndex = 5;
            this.buttonUpdateRequest.Text = "Редактировать заявку";
            this.buttonUpdateRequest.UseVisualStyleBackColor = true;
            this.buttonUpdateRequest.Click += new System.EventHandler(this.buttonUpdateRequest_Click);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Location = new System.Drawing.Point(154, 42);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(136, 23);
            this.buttonUpdateClient.TabIndex = 6;
            this.buttonUpdateClient.Text = "Редактировать клиента";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // buttonListClients
            // 
            this.buttonListClients.Location = new System.Drawing.Point(654, 52);
            this.buttonListClients.Name = "buttonListClients";
            this.buttonListClients.Size = new System.Drawing.Size(134, 23);
            this.buttonListClients.TabIndex = 7;
            this.buttonListClients.Text = "Список клиентов";
            this.buttonListClients.UseVisualStyleBackColor = true;
            this.buttonListClients.Click += new System.EventHandler(this.buttonListClients_Click);
            // 
            // buttonListRequests
            // 
            this.buttonListRequests.Location = new System.Drawing.Point(654, 81);
            this.buttonListRequests.Name = "buttonListRequests";
            this.buttonListRequests.Size = new System.Drawing.Size(134, 23);
            this.buttonListRequests.TabIndex = 8;
            this.buttonListRequests.Text = "Список заявок";
            this.buttonListRequests.UseVisualStyleBackColor = true;
            this.buttonListRequests.Click += new System.EventHandler(this.buttonListRequests_Click);
            // 
            // buttonListUsers
            // 
            this.buttonListUsers.Location = new System.Drawing.Point(261, 415);
            this.buttonListUsers.Name = "buttonListUsers";
            this.buttonListUsers.Size = new System.Drawing.Size(190, 23);
            this.buttonListUsers.TabIndex = 12;
            this.buttonListUsers.Text = "Управление пользователями";
            this.buttonListUsers.UseVisualStyleBackColor = true;
            this.buttonListUsers.Click += new System.EventHandler(this.buttonListUsers_Click);
            // 
            // buttonTrackRequest
            // 
            this.buttonTrackRequest.Location = new System.Drawing.Point(654, 110);
            this.buttonTrackRequest.Name = "buttonTrackRequest";
            this.buttonTrackRequest.Size = new System.Drawing.Size(134, 23);
            this.buttonTrackRequest.TabIndex = 13;
            this.buttonTrackRequest.Text = "Отслеживать заявку";
            this.buttonTrackRequest.UseVisualStyleBackColor = true;
            this.buttonTrackRequest.Click += new System.EventHandler(this.buttonTrackRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTrackRequest);
            this.Controls.Add(this.buttonListUsers);
            this.Controls.Add(this.buttonListRequests);
            this.Controls.Add(this.buttonListClients);
            this.Controls.Add(this.buttonUpdateClient);
            this.Controls.Add(this.buttonUpdateRequest);
            this.Controls.Add(this.buttonFindClintByPhoneNumber);
            this.Controls.Add(this.buttonClientAdd);
            this.Controls.Add(this.buttonRequestAdd);
            this.Controls.Add(this.deleteDefaultRepos);
            this.Controls.Add(this.createDefaultRepos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createDefaultRepos;
        private System.Windows.Forms.Button deleteDefaultRepos;
        private System.Windows.Forms.Button buttonRequestAdd;
        private System.Windows.Forms.Button buttonClientAdd;
        private System.Windows.Forms.Button buttonFindClintByPhoneNumber;
        private System.Windows.Forms.Button buttonUpdateRequest;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.Button buttonListClients;
        private System.Windows.Forms.Button buttonListRequests;
        private System.Windows.Forms.Button buttonListUsers;
        private System.Windows.Forms.Button buttonTrackRequest;
    }
}

