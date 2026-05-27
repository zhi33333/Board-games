namespace 棋排類遊戲
{
    partial class Form1
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.Location = new System.Drawing.Point(0, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(580, 40);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "目前玩家：X";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.White;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn00.Location = new System.Drawing.Point(100, 150);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(120, 120);
            this.btn00.TabIndex = 1;
            this.btn00.UseVisualStyleBackColor = false;
            // 
            // btn01
            // 
            this.btn01.BackColor = System.Drawing.Color.White;
            this.btn01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn01.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01.Location = new System.Drawing.Point(230, 150);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(120, 120);
            this.btn01.TabIndex = 2;
            this.btn01.UseVisualStyleBackColor = false;
            // 
            // btn02
            // 
            this.btn02.BackColor = System.Drawing.Color.White;
            this.btn02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn02.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn02.Location = new System.Drawing.Point(360, 150);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(120, 120);
            this.btn02.TabIndex = 3;
            this.btn02.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.White;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn10.Location = new System.Drawing.Point(100, 280);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(120, 120);
            this.btn10.TabIndex = 4;
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.White;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn11.Location = new System.Drawing.Point(230, 280);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(120, 120);
            this.btn11.TabIndex = 5;
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.White;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn12.Location = new System.Drawing.Point(360, 280);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(120, 120);
            this.btn12.TabIndex = 6;
            this.btn12.UseVisualStyleBackColor = false;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.White;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn20.Location = new System.Drawing.Point(100, 410);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(120, 120);
            this.btn20.TabIndex = 7;
            this.btn20.UseVisualStyleBackColor = false;
            // 
            // btn21
            // 
            this.btn21.BackColor = System.Drawing.Color.White;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn21.Location = new System.Drawing.Point(230, 410);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(120, 120);
            this.btn21.TabIndex = 8;
            this.btn21.UseVisualStyleBackColor = false;
            // 
            // btn22
            // 
            this.btn22.BackColor = System.Drawing.Color.White;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn22.Location = new System.Drawing.Point(360, 410);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(120, 120);
            this.btn22.TabIndex = 9;
            this.btn22.UseVisualStyleBackColor = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestart.Location = new System.Drawing.Point(200, 560);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(180, 50);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "重新開始";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "棋牌類遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btnRestart;
    }
}

