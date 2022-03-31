
namespace WindowsForm6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_cay = new System.Windows.Forms.CheckBox();
            this.checkBox_kahve = new System.Windows.Forms.CheckBox();
            this.checkBox_hamburger = new System.Windows.Forms.CheckBox();
            this.checkBox_pizza = new System.Windows.Forms.CheckBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_cay
            // 
            this.checkBox_cay.AutoSize = true;
            this.checkBox_cay.BackColor = System.Drawing.Color.IndianRed;
            this.checkBox_cay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_cay.Location = new System.Drawing.Point(65, 65);
            this.checkBox_cay.Name = "checkBox_cay";
            this.checkBox_cay.Size = new System.Drawing.Size(98, 21);
            this.checkBox_cay.TabIndex = 0;
            this.checkBox_cay.Text = "ÇAY 2 TL";
            this.checkBox_cay.UseVisualStyleBackColor = false;
            // 
            // checkBox_kahve
            // 
            this.checkBox_kahve.AutoSize = true;
            this.checkBox_kahve.BackColor = System.Drawing.Color.IndianRed;
            this.checkBox_kahve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_kahve.Location = new System.Drawing.Point(65, 110);
            this.checkBox_kahve.Name = "checkBox_kahve";
            this.checkBox_kahve.Size = new System.Drawing.Size(119, 21);
            this.checkBox_kahve.TabIndex = 1;
            this.checkBox_kahve.Text = "KAHVE 5 TL";
            this.checkBox_kahve.UseVisualStyleBackColor = false;
            // 
            // checkBox_hamburger
            // 
            this.checkBox_hamburger.AutoSize = true;
            this.checkBox_hamburger.BackColor = System.Drawing.Color.IndianRed;
            this.checkBox_hamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_hamburger.Location = new System.Drawing.Point(65, 156);
            this.checkBox_hamburger.Name = "checkBox_hamburger";
            this.checkBox_hamburger.Size = new System.Drawing.Size(175, 21);
            this.checkBox_hamburger.TabIndex = 2;
            this.checkBox_hamburger.Text = "HAMBURGER 15 TL";
            this.checkBox_hamburger.UseVisualStyleBackColor = false;
            // 
            // checkBox_pizza
            // 
            this.checkBox_pizza.AutoSize = true;
            this.checkBox_pizza.BackColor = System.Drawing.Color.IndianRed;
            this.checkBox_pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_pizza.Location = new System.Drawing.Point(65, 198);
            this.checkBox_pizza.Name = "checkBox_pizza";
            this.checkBox_pizza.Size = new System.Drawing.Size(121, 21);
            this.checkBox_pizza.TabIndex = 3;
            this.checkBox_pizza.Text = "PİZZA 20 TL";
            this.checkBox_pizza.UseVisualStyleBackColor = false;
            this.checkBox_pizza.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(65, 271);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(222, 58);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(363, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "TUTAR : ";
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutar.Location = new System.Drawing.Point(503, 65);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(28, 29);
            this.lbl_tutar.TabIndex = 6;
            this.lbl_tutar.Text = "0";
            this.lbl_tutar.Click += new System.EventHandler(this.lbl_tutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(631, 408);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.checkBox_pizza);
            this.Controls.Add(this.checkBox_hamburger);
            this.Controls.Add(this.checkBox_kahve);
            this.Controls.Add(this.checkBox_cay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_cay;
        private System.Windows.Forms.CheckBox checkBox_kahve;
        private System.Windows.Forms.CheckBox checkBox_hamburger;
        private System.Windows.Forms.CheckBox checkBox_pizza;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tutar;
    }
}

