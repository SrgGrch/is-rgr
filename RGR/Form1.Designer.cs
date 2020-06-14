namespace RGR
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_eventName = new System.Windows.Forms.Label();
            this.label_eventDescription = new System.Windows.Forms.Label();
            this.label_eventType = new System.Windows.Forms.Label();
            this.textBox_eventName = new System.Windows.Forms.TextBox();
            this.textBox_eventDescription = new System.Windows.Forms.TextBox();
            this.comboBox_eventType = new System.Windows.Forms.ComboBox();
            this.textBox_placeId = new System.Windows.Forms.TextBox();
            this.textBox_placeName = new System.Windows.Forms.TextBox();
            this.label_placeId = new System.Windows.Forms.Label();
            this.label_placeName = new System.Windows.Forms.Label();
            this.label_placeDescription = new System.Windows.Forms.Label();
            this.textBox_placeDescription = new System.Windows.Forms.TextBox();
            this.button_previous = new MaterialSkin.Controls.MaterialFlatButton();
            this.button_next = new MaterialSkin.Controls.MaterialFlatButton();
            this.label_eventPlace = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_organizaerDecsription = new System.Windows.Forms.TextBox();
            this.label_organizaerDecsription = new System.Windows.Forms.Label();
            this.label_organizaerName = new System.Windows.Forms.Label();
            this.label_organizaerId = new System.Windows.Forms.Label();
            this.textBox_organizaerName = new System.Windows.Forms.TextBox();
            this.textBox_organizaerId = new System.Windows.Forms.TextBox();
            this.listBox_participants = new System.Windows.Forms.ListBox();
            this.listBox_guests = new System.Windows.Forms.ListBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.button_savePlace = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_eventName
            // 
            this.label_eventName.Location = new System.Drawing.Point(12, 23);
            this.label_eventName.Name = "label_eventName";
            this.label_eventName.Size = new System.Drawing.Size(70, 20);
            this.label_eventName.TabIndex = 0;
            this.label_eventName.Text = "Название";
            // 
            // label_eventDescription
            // 
            this.label_eventDescription.Location = new System.Drawing.Point(12, 78);
            this.label_eventDescription.Name = "label_eventDescription";
            this.label_eventDescription.Size = new System.Drawing.Size(70, 20);
            this.label_eventDescription.TabIndex = 1;
            this.label_eventDescription.Text = "Описание";
            // 
            // label_eventType
            // 
            this.label_eventType.Location = new System.Drawing.Point(12, 190);
            this.label_eventType.Name = "label_eventType";
            this.label_eventType.Size = new System.Drawing.Size(107, 20);
            this.label_eventType.TabIndex = 3;
            this.label_eventType.Text = "Тип мероприятия";
            // 
            // textBox_eventName
            // 
            this.textBox_eventName.Location = new System.Drawing.Point(26, 46);
            this.textBox_eventName.Name = "textBox_eventName";
            this.textBox_eventName.Size = new System.Drawing.Size(237, 20);
            this.textBox_eventName.TabIndex = 4;
            this.textBox_eventName.TextChanged += new System.EventHandler(this.textBox_eventName_TextChanged);
            // 
            // textBox_eventDescription
            // 
            this.textBox_eventDescription.Location = new System.Drawing.Point(26, 101);
            this.textBox_eventDescription.Multiline = true;
            this.textBox_eventDescription.Name = "textBox_eventDescription";
            this.textBox_eventDescription.Size = new System.Drawing.Size(237, 83);
            this.textBox_eventDescription.TabIndex = 5;
            this.textBox_eventDescription.TextChanged += new System.EventHandler(this.textBox_eventDescription_TextChanged);
            // 
            // comboBox_eventType
            // 
            this.comboBox_eventType.FormattingEnabled = true;
            this.comboBox_eventType.Location = new System.Drawing.Point(26, 213);
            this.comboBox_eventType.Name = "comboBox_eventType";
            this.comboBox_eventType.Size = new System.Drawing.Size(236, 21);
            this.comboBox_eventType.TabIndex = 6;
            // 
            // textBox_placeId
            // 
            this.textBox_placeId.Location = new System.Drawing.Point(95, 275);
            this.textBox_placeId.Name = "textBox_placeId";
            this.textBox_placeId.Size = new System.Drawing.Size(237, 20);
            this.textBox_placeId.TabIndex = 7;
            this.textBox_placeId.TextChanged += new System.EventHandler(this.textBox_placeId_TextChanged);
            // 
            // textBox_placeName
            // 
            this.textBox_placeName.Enabled = false;
            this.textBox_placeName.Location = new System.Drawing.Point(95, 301);
            this.textBox_placeName.Name = "textBox_placeName";
            this.textBox_placeName.Size = new System.Drawing.Size(237, 20);
            this.textBox_placeName.TabIndex = 8;
            // 
            // label_placeId
            // 
            this.label_placeId.Location = new System.Drawing.Point(26, 275);
            this.label_placeId.Name = "label_placeId";
            this.label_placeId.Size = new System.Drawing.Size(63, 20);
            this.label_placeId.TabIndex = 10;
            this.label_placeId.Text = "id:";
            // 
            // label_placeName
            // 
            this.label_placeName.Location = new System.Drawing.Point(26, 301);
            this.label_placeName.Name = "label_placeName";
            this.label_placeName.Size = new System.Drawing.Size(63, 20);
            this.label_placeName.TabIndex = 11;
            this.label_placeName.Text = "Название:";
            // 
            // label_placeDescription
            // 
            this.label_placeDescription.Location = new System.Drawing.Point(26, 327);
            this.label_placeDescription.Name = "label_placeDescription";
            this.label_placeDescription.Size = new System.Drawing.Size(63, 20);
            this.label_placeDescription.TabIndex = 12;
            this.label_placeDescription.Text = "Описание:";
            // 
            // textBox_placeDescription
            // 
            this.textBox_placeDescription.Enabled = false;
            this.textBox_placeDescription.Location = new System.Drawing.Point(95, 324);
            this.textBox_placeDescription.Multiline = true;
            this.textBox_placeDescription.Name = "textBox_placeDescription";
            this.textBox_placeDescription.Size = new System.Drawing.Size(237, 83);
            this.textBox_placeDescription.TabIndex = 13;
            // 
            // button_previous
            // 
            this.button_previous.AutoSize = true;
            this.button_previous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_previous.Depth = 0;
            this.button_previous.Icon = null;
            this.button_previous.Location = new System.Drawing.Point(694, 11);
            this.button_previous.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_previous.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_previous.Name = "button_previous";
            this.button_previous.Primary = false;
            this.button_previous.Size = new System.Drawing.Size(32, 36);
            this.button_previous.TabIndex = 14;
            this.button_previous.Text = "<-";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // button_next
            // 
            this.button_next.AutoSize = true;
            this.button_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_next.Depth = 0;
            this.button_next.Icon = null;
            this.button_next.Location = new System.Drawing.Point(734, 11);
            this.button_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_next.Name = "button_next";
            this.button_next.Primary = false;
            this.button_next.Size = new System.Drawing.Size(33, 36);
            this.button_next.TabIndex = 15;
            this.button_next.Text = "->";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_eventPlace
            // 
            this.label_eventPlace.Location = new System.Drawing.Point(12, 245);
            this.label_eventPlace.Name = "label_eventPlace";
            this.label_eventPlace.Size = new System.Drawing.Size(107, 20);
            this.label_eventPlace.TabIndex = 2;
            this.label_eventPlace.Text = "Место проведения";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(376, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Организатор";
            // 
            // textBox_organizaerDecsription
            // 
            this.textBox_organizaerDecsription.Location = new System.Drawing.Point(445, 324);
            this.textBox_organizaerDecsription.Multiline = true;
            this.textBox_organizaerDecsription.Name = "textBox_organizaerDecsription";
            this.textBox_organizaerDecsription.Size = new System.Drawing.Size(237, 83);
            this.textBox_organizaerDecsription.TabIndex = 22;
            this.textBox_organizaerDecsription.TextChanged += new System.EventHandler(this.textBox_organizerDescription_TextChanged);
            // 
            // label_organizaerDecsription
            // 
            this.label_organizaerDecsription.Location = new System.Drawing.Point(376, 327);
            this.label_organizaerDecsription.Name = "label_organizaerDecsription";
            this.label_organizaerDecsription.Size = new System.Drawing.Size(63, 20);
            this.label_organizaerDecsription.TabIndex = 21;
            this.label_organizaerDecsription.Text = "Описание:";
            // 
            // label_organizaerName
            // 
            this.label_organizaerName.Location = new System.Drawing.Point(376, 301);
            this.label_organizaerName.Name = "label_organizaerName";
            this.label_organizaerName.Size = new System.Drawing.Size(63, 20);
            this.label_organizaerName.TabIndex = 20;
            this.label_organizaerName.Text = "Название:";
            // 
            // label_organizaerId
            // 
            this.label_organizaerId.Location = new System.Drawing.Point(376, 275);
            this.label_organizaerId.Name = "label_organizaerId";
            this.label_organizaerId.Size = new System.Drawing.Size(63, 20);
            this.label_organizaerId.TabIndex = 19;
            this.label_organizaerId.Text = "id:";
            // 
            // textBox_organizaerName
            // 
            this.textBox_organizaerName.Location = new System.Drawing.Point(445, 301);
            this.textBox_organizaerName.Name = "textBox_organizaerName";
            this.textBox_organizaerName.Size = new System.Drawing.Size(237, 20);
            this.textBox_organizaerName.TabIndex = 18;
            // 
            // textBox_organizaerId
            // 
            this.textBox_organizaerId.Enabled = false;
            this.textBox_organizaerId.Location = new System.Drawing.Point(445, 275);
            this.textBox_organizaerId.Name = "textBox_organizaerId";
            this.textBox_organizaerId.Size = new System.Drawing.Size(237, 20);
            this.textBox_organizaerId.TabIndex = 17;
            // 
            // listBox_participants
            // 
            this.listBox_participants.FormattingEnabled = true;
            this.listBox_participants.Location = new System.Drawing.Point(359, 50);
            this.listBox_participants.Name = "listBox_participants";
            this.listBox_participants.Size = new System.Drawing.Size(155, 160);
            this.listBox_participants.TabIndex = 23;
            // 
            // listBox_guests
            // 
            this.listBox_guests.FormattingEnabled = true;
            this.listBox_guests.Location = new System.Drawing.Point(536, 50);
            this.listBox_guests.Name = "listBox_guests";
            this.listBox_guests.Size = new System.Drawing.Size(155, 160);
            this.listBox_guests.TabIndex = 24;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(445, 416);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(102, 36);
            this.materialFlatButton1.TabIndex = 25;
            this.materialFlatButton1.Text = "Сохранить";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // button_savePlace
            // 
            this.button_savePlace.AutoSize = true;
            this.button_savePlace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_savePlace.Depth = 0;
            this.button_savePlace.Icon = null;
            this.button_savePlace.Location = new System.Drawing.Point(26, 416);
            this.button_savePlace.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_savePlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_savePlace.Name = "button_savePlace";
            this.button_savePlace.Primary = false;
            this.button_savePlace.Size = new System.Drawing.Size(152, 36);
            this.button_savePlace.TabIndex = 26;
            this.button_savePlace.Text = "Сохранить место";
            this.button_savePlace.UseVisualStyleBackColor = true;
            this.button_savePlace.Click += new System.EventHandler(this.button_savePlace_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(605, 416);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(77, 36);
            this.materialFlatButton3.TabIndex = 27;
            this.materialFlatButton3.Text = "Отмена";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(12, 447);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 15);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Изменять местро проведение";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBoxEditPlace_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.button_savePlace);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.listBox_guests);
            this.Controls.Add(this.listBox_participants);
            this.Controls.Add(this.textBox_organizaerDecsription);
            this.Controls.Add(this.label_organizaerDecsription);
            this.Controls.Add(this.label_organizaerName);
            this.Controls.Add(this.label_organizaerId);
            this.Controls.Add(this.textBox_organizaerName);
            this.Controls.Add(this.textBox_organizaerId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_previous);
            this.Controls.Add(this.textBox_placeDescription);
            this.Controls.Add(this.label_placeDescription);
            this.Controls.Add(this.label_placeName);
            this.Controls.Add(this.label_placeId);
            this.Controls.Add(this.textBox_placeName);
            this.Controls.Add(this.textBox_placeId);
            this.Controls.Add(this.comboBox_eventType);
            this.Controls.Add(this.textBox_eventDescription);
            this.Controls.Add(this.textBox_eventName);
            this.Controls.Add(this.label_eventType);
            this.Controls.Add(this.label_eventPlace);
            this.Controls.Add(this.label_eventDescription);
            this.Controls.Add(this.label_eventName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private MaterialSkin.Controls.MaterialFlatButton button_next;
        private MaterialSkin.Controls.MaterialFlatButton button_previous;
        private MaterialSkin.Controls.MaterialFlatButton button_savePlace;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox_eventType;
        private System.Windows.Forms.Label label_eventDescription;
        private System.Windows.Forms.Label label_eventName;
        private System.Windows.Forms.Label label_eventPlace;
        private System.Windows.Forms.Label label_eventType;
        private System.Windows.Forms.Label label_organizaerDecsription;
        private System.Windows.Forms.Label label_organizaerId;
        private System.Windows.Forms.Label label_organizaerName;
        private System.Windows.Forms.Label label_placeDescription;
        private System.Windows.Forms.Label label_placeId;
        private System.Windows.Forms.Label label_placeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_guests;
        private System.Windows.Forms.ListBox listBox_participants;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.TextBox textBox_eventDescription;
        private System.Windows.Forms.TextBox textBox_eventName;
        private System.Windows.Forms.TextBox textBox_organizaerDecsription;
        private System.Windows.Forms.TextBox textBox_organizaerId;
        private System.Windows.Forms.TextBox textBox_organizaerName;
        private System.Windows.Forms.TextBox textBox_placeDescription;
        private System.Windows.Forms.TextBox textBox_placeId;
        private System.Windows.Forms.TextBox textBox_placeName;

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

