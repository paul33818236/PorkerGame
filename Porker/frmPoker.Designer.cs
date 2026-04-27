namespace Porker
{
    partial class frmPoker
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum = new System.Windows.Forms.Label();
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.GroupBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNum.Location = new System.Drawing.Point(806, 510);
            this.lblNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(2, 26);
            this.lblNum.TabIndex = 2;
            this.lblNum.UseWaitCursor = true;
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(129, 65);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Size = new System.Drawing.Size(1097, 442);
            this.grpPoker.TabIndex = 3;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.btnChangeCard);
            this.groupBox1.Controls.Add(this.btnDealCard);
            this.groupBox1.Location = new System.Drawing.Point(129, 539);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(742, 74);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(177, 36);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(519, 54);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(155, 71);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(298, 54);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(155, 71);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(28, 54);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(155, 71);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // payment
            // 
            this.payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.payment.Controls.Add(this.btnBet);
            this.payment.Controls.Add(this.label2);
            this.payment.Controls.Add(this.label1);
            this.payment.Controls.Add(this.txtBet);
            this.payment.Controls.Add(this.txtMoney);
            this.payment.Location = new System.Drawing.Point(129, 746);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(971, 100);
            this.payment.TabIndex = 4;
            this.payment.TabStop = false;
            this.payment.Text = "下注功能";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(848, 30);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(117, 56);
            this.btnBet.TabIndex = 9;
            this.btnBet.Text = "押注";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "押注金額";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "總資金";
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(574, 35);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(223, 36);
            this.txtBet.TabIndex = 6;
            // 
            // txtMoney
            // 
            this.txtMoney.HideSelection = false;
            this.txtMoney.Location = new System.Drawing.Point(150, 35);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(196, 36);
            this.txtMoney.TabIndex = 5;
            this.txtMoney.Text = "100000";
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 900);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPoker);
            this.Controls.Add(this.lblNum);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPoker";
            this.Text = "poker_game";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.payment.ResumeLayout(false);
            this.payment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.GroupBox payment;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.TextBox txtMoney;
    }
}

