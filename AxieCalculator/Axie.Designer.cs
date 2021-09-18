
namespace AxieCalculator
{
    partial class Axie
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
            this.lbcard = new System.Windows.Forms.Label();
            this.lbE = new System.Windows.Forms.Label();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.btnMinusCard = new System.Windows.Forms.Button();
            this.btnAddE = new System.Windows.Forms.Button();
            this.btnMinusE = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbcard
            // 
            this.lbcard.AutoSize = true;
            this.lbcard.Location = new System.Drawing.Point(2, 20);
            this.lbcard.Name = "lbcard";
            this.lbcard.Size = new System.Drawing.Size(43, 20);
            this.lbcard.TabIndex = 0;
            this.lbcard.Text = "Card:";
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Location = new System.Drawing.Point(130, 20);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(57, 20);
            this.lbE.TabIndex = 1;
            this.lbE.Text = "Energy:";
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(66, 11);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(58, 29);
            this.btnAddCard.TabIndex = 2;
            this.btnAddCard.Text = "+card";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // btnMinusCard
            // 
            this.btnMinusCard.Location = new System.Drawing.Point(66, 46);
            this.btnMinusCard.Name = "btnMinusCard";
            this.btnMinusCard.Size = new System.Drawing.Size(58, 29);
            this.btnMinusCard.TabIndex = 3;
            this.btnMinusCard.Text = "-card";
            this.btnMinusCard.UseVisualStyleBackColor = true;
            this.btnMinusCard.Click += new System.EventHandler(this.btnMinusCard_Click);
            // 
            // btnAddE
            // 
            this.btnAddE.Location = new System.Drawing.Point(224, 11);
            this.btnAddE.Name = "btnAddE";
            this.btnAddE.Size = new System.Drawing.Size(58, 29);
            this.btnAddE.TabIndex = 4;
            this.btnAddE.Text = "+E";
            this.btnAddE.UseVisualStyleBackColor = true;
            this.btnAddE.Click += new System.EventHandler(this.btnAddE_Click);
            // 
            // btnMinusE
            // 
            this.btnMinusE.Location = new System.Drawing.Point(224, 46);
            this.btnMinusE.Name = "btnMinusE";
            this.btnMinusE.Size = new System.Drawing.Size(58, 29);
            this.btnMinusE.TabIndex = 5;
            this.btnMinusE.Text = "-E";
            this.btnMinusE.UseVisualStyleBackColor = true;
            this.btnMinusE.Click += new System.EventHandler(this.btnMinusE_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(300, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(71, 29);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(300, 46);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(71, 29);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Axie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 84);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnMinusE);
            this.Controls.Add(this.btnAddE);
            this.Controls.Add(this.btnMinusCard);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.lbE);
            this.Controls.Add(this.lbcard);
            this.Name = "Axie";
            this.Text = "Axie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcard;
        private System.Windows.Forms.Label lbE;
        private System.Windows.Forms.Button btnAddCard;
        private System.Windows.Forms.Button btnMinusCard;
        private System.Windows.Forms.Button btnAddE;
        private System.Windows.Forms.Button btnMinusE;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
    }
}