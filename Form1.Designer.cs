namespace OOP4._1
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
            this.ShowB = new System.Windows.Forms.Button();
            this.DeleteCB = new System.Windows.Forms.Button();
            this.ClearSB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.PanelD = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelD.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowB
            // 
            this.ShowB.BackColor = System.Drawing.SystemColors.Info;
            this.ShowB.Location = new System.Drawing.Point(12, 12);
            this.ShowB.Name = "ShowB";
            this.ShowB.Size = new System.Drawing.Size(96, 75);
            this.ShowB.TabIndex = 0;
            this.ShowB.Text = "Показать объекты из хранилища";
            this.ShowB.UseVisualStyleBackColor = false;
            // 
            // DeleteCB
            // 
            this.DeleteCB.BackColor = System.Drawing.SystemColors.Info;
            this.DeleteCB.Location = new System.Drawing.Point(12, 348);
            this.DeleteCB.Name = "DeleteCB";
            this.DeleteCB.Size = new System.Drawing.Size(96, 90);
            this.DeleteCB.TabIndex = 1;
            this.DeleteCB.Text = "Удалить выделенные элементы везде\r\n";
            this.DeleteCB.UseVisualStyleBackColor = false;
            // 
            // ClearSB
            // 
            this.ClearSB.BackColor = System.Drawing.SystemColors.Info;
            this.ClearSB.Location = new System.Drawing.Point(687, 12);
            this.ClearSB.Name = "ClearSB";
            this.ClearSB.Size = new System.Drawing.Size(101, 75);
            this.ClearSB.TabIndex = 2;
            this.ClearSB.Text = "Удалить элементы из хранилища";
            this.ClearSB.UseVisualStyleBackColor = false;
            // 
            // ClearB
            // 
            this.ClearB.BackColor = System.Drawing.SystemColors.Info;
            this.ClearB.Location = new System.Drawing.Point(687, 348);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(101, 90);
            this.ClearB.TabIndex = 3;
            this.ClearB.Text = "Стереть все с панели";
            this.ClearB.UseVisualStyleBackColor = false;
            // 
            // PanelD
            // 
            this.PanelD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PanelD.Controls.Add(this.label1);
            this.PanelD.Location = new System.Drawing.Point(114, 12);
            this.PanelD.Name = "PanelD";
            this.PanelD.Size = new System.Drawing.Size(567, 426);
            this.PanelD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рабочая зона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelD);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.ClearSB);
            this.Controls.Add(this.DeleteCB);
            this.Controls.Add(this.ShowB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelD.ResumeLayout(false);
            this.PanelD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowB;
        private System.Windows.Forms.Button DeleteCB;
        private System.Windows.Forms.Button ClearSB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Panel PanelD;
        private System.Windows.Forms.Label label1;
    }
}

