using System;
using System.Drawing;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class SideBar : UserControl
    {
        private Form f => ParentForm;

        public SideBar()
        {
            InitializeComponent();
            HomeSet.Text = "https://www.google.com";
        }

        private void AddBookmarkButton_Click(object sender, EventArgs e)
        {
            BookmarkList.Items.Add(BookmarkSet.Text);
        }

        private void SubtractBookmarkButton_Click(object sender, EventArgs e)
        {
            BookmarkList.Items.Remove(BookmarkList.CheckedItems);
        }

        private void CloseButton2_Click(object sender, EventArgs e)
        {
            Settings.Hide();
            CloseButton.Hide();
            VersionLabel.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Settings.Hide();
            CloseButton.Hide();
            VersionLabel.Hide();
        }

        private void SettingsButton3_Click(object sender, EventArgs e)
        {
            Settings.Show();
            CloseButton.Show();
            VersionLabel.Show();
        }

        private void PersonalizationLabel_Click(object sender, EventArgs e)
        {
            PersonalizationLabel.Show();
            PersonalizationImage.Show();
            HomePageLabel.Show();
            HomeSet.Show();
            ColorLabel.Show();
            pictureBox11.Show();
            pictureBox12.Show();
            pictureBox13.Show();
            pictureBox14.Show();
            pictureBox15.Show();
            pictureBox16.Show();
            pictureBox17.Show();
            pictureBox18.Show();
            pictureBox19.Show();
            pictureBox20.Show();
            pictureBox21.Show();
            pictureBox22.Show();
            pictureBox23.Show();
            pictureBox24.Show();
            pictureBox25.Show();
            pictureBox26.Show();
            pictureBox27.Show();
            pictureBox28.Show();
            pictureBox29.Show();
            pictureBox30.Show();
            pictureBox31.Show();
            pictureBox32.Show();
            pictureBox33.Show();
            pictureBox34.Show();
            pictureBox35.Show();
            pictureBox36.Show();
            pictureBox37.Show();
            pictureBox38.Show();
            pictureBox39.Show();
            pictureBox41.Show();
            pictureBox42.Show();
            pictureBox43.Show();
            pictureBox44.Show();
            pictureBox45.Show();
            pictureBox46.Show();
            pictureBox47.Show();
            pictureBox48.Show();
            pictureBox49.Show();
            pictureBox50.Show();
            pictureBox52.Show();
            pictureBox53.Show();
            pictureBox54.Show();
            pictureBox55.Show();
            pictureBox56.Show();
            pictureBox57.Show();
            pictureBox58.Show();
            pictureBox59.Show();
            BookmarkList.Hide();
        }

        private void BookmarkLabel_Click(object sender, EventArgs e)
        {
            BookmarkList.Show();
            BookmarkSet.Show();
            BookmarkLabel.Show();
            BookmarkImage.Show();
            SubtractBookmarkButton.Show();
            HomePageLabel.Hide();
            HomeSet.Hide();
            ColorLabel.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox23.Hide();
            pictureBox24.Hide();
            pictureBox25.Hide();
            pictureBox26.Hide();
            pictureBox27.Hide();
            pictureBox28.Hide();
            pictureBox29.Hide();
            pictureBox30.Hide();
            pictureBox31.Hide();
            pictureBox32.Hide();
            pictureBox33.Hide();
            pictureBox34.Hide();
            pictureBox35.Hide();
            pictureBox36.Hide();
            pictureBox37.Hide();
            pictureBox38.Hide();
            pictureBox39.Hide();
            pictureBox40.Hide();
            pictureBox41.Hide();
            pictureBox42.Hide();
            pictureBox43.Hide();
            pictureBox44.Hide();
            pictureBox45.Hide();
            pictureBox46.Hide();
            pictureBox47.Hide();
            pictureBox48.Hide();
            pictureBox49.Hide();
            pictureBox50.Hide();
            pictureBox52.Hide();
            pictureBox53.Hide();
            pictureBox54.Hide();
            pictureBox55.Hide();
            pictureBox56.Hide();
            pictureBox57.Hide();
            pictureBox58.Hide();
            pictureBox59.Hide();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox31.BackColor;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox14.BackColor;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox23.BackColor;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox11.BackColor;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox12.BackColor;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox13.BackColor;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox15.BackColor;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox16.BackColor;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox17.BackColor;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox19.BackColor;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox30.BackColor;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox29.BackColor;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox28.BackColor;
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox50.BackColor;
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox59.BackColor;
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox59.BackColor;
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox57.BackColor;
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox56.BackColor;
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox55.BackColor;
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox54.BackColor;
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox53.BackColor;
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox52.BackColor;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox25.BackColor;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox24.BackColor;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox22.BackColor;
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox49.BackColor;
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox48.BackColor;
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox47.BackColor;
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox46.BackColor;
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox45.BackColor;
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox44.BackColor;
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox43.BackColor;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox42.BackColor;
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox41.BackColor;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox40.BackColor;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox39.BackColor;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox38.BackColor;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox37.BackColor;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox36.BackColor;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox35.BackColor;
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox34.BackColor;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox33.BackColor;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox32.BackColor;
        }
        
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox20.BackColor;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox18.BackColor;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox21.BackColor;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox27.BackColor;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            f.BackColor = pictureBox26.BackColor;
        }

        internal void HideAll()
        {
            Settings.Hide();
            CloseButton.Hide();
            VersionLabel.Hide();
            SettingsMenu.Hide();
            PersonalizationLabel.Hide();
            PersonalizationImage.Hide();
            HomePageLabel.Hide();
            HomeSet.Hide();
            ColorLabel.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox23.Hide();
            pictureBox24.Hide();
            pictureBox25.Hide();
            pictureBox26.Hide();
            pictureBox27.Hide();
            pictureBox28.Hide();
            pictureBox29.Hide();
            pictureBox30.Hide();
            pictureBox31.Hide();
            pictureBox32.Hide();
            pictureBox33.Hide();
            pictureBox34.Hide();
            pictureBox35.Hide();
            pictureBox36.Hide();
            pictureBox37.Hide();
            pictureBox38.Hide();
            pictureBox39.Hide();
            pictureBox40.Hide();
            pictureBox41.Hide();
            pictureBox42.Hide();
            pictureBox43.Hide();
            pictureBox44.Hide();
            pictureBox45.Hide();
            pictureBox46.Hide();
            pictureBox47.Hide();
            pictureBox48.Hide();
            pictureBox49.Hide();
            pictureBox50.Hide();
            pictureBox52.Hide();
            pictureBox53.Hide();
            pictureBox54.Hide();
            pictureBox55.Hide();
            pictureBox56.Hide();
            pictureBox57.Hide();
            pictureBox58.Hide();
            pictureBox59.Hide();
            BookmarkList.Hide();
            BookmarkSet.Hide();
            BookmarkLabel.Hide();
            BookmarkImage.Hide();
            SubtractBookmarkButton.Hide();
        }

        internal void button1_Click_1(object sender, EventArgs e)
        {
            SettingsMenu.Hide();
            PersonalizationLabel.Hide();
            PersonalizationImage.Hide();
            HomePageLabel.Hide();
            HomeSet.Hide();
            ColorLabel.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox23.Hide();
            pictureBox24.Hide();
            pictureBox25.Hide();
            pictureBox26.Hide();
            pictureBox27.Hide();
            pictureBox28.Hide();
            pictureBox29.Hide();
            pictureBox30.Hide();
            pictureBox31.Hide();
            pictureBox32.Hide();
            pictureBox33.Hide();
            pictureBox34.Hide();
            pictureBox35.Hide();
            pictureBox36.Hide();
            pictureBox37.Hide();
            pictureBox38.Hide();
            pictureBox39.Hide();
            pictureBox41.Hide();
            pictureBox42.Hide();
            pictureBox43.Hide();
            pictureBox44.Hide();
            pictureBox45.Hide();
            pictureBox46.Hide();
            pictureBox47.Hide();
            pictureBox48.Hide();
            pictureBox49.Hide();
            pictureBox50.Hide();
            pictureBox52.Hide();
            pictureBox53.Hide();
            pictureBox54.Hide();
            pictureBox55.Hide();
            pictureBox56.Hide();
            pictureBox57.Hide();
            pictureBox58.Hide();
            pictureBox59.Hide();
            BookmarkList.Hide();
            BookmarkSet.Hide();
            BookmarkLabel.Hide();
            BookmarkImage.Hide();
            SubtractBookmarkButton.Hide();
            SubtractBookmarkButton.Hide();
        }

        internal void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsMenu.Show();
            BookmarkLabel.Show();
            BookmarkImage.Show();
            PersonalizationLabel.Show();
            PersonalizationImage.Show();
        }

        internal void CloseButton_Click(object sender, EventArgs e)
        {
            SettingsMenu.Hide();
            PersonalizationLabel.Hide();
            PersonalizationImage.Hide();
            HomePageLabel.Hide();
            HomeSet.Hide();
            ColorLabel.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox23.Hide();
            pictureBox24.Hide();
            pictureBox25.Hide();
            pictureBox26.Hide();
            pictureBox27.Hide();
            pictureBox28.Hide();
            pictureBox29.Hide();
            pictureBox30.Hide();
            pictureBox31.Hide();
            pictureBox32.Hide();
            pictureBox33.Hide();
            pictureBox34.Hide();
            pictureBox35.Hide();
            pictureBox36.Hide();
            pictureBox37.Hide();
            pictureBox38.Hide();
            pictureBox39.Hide();
            pictureBox41.Hide();
            pictureBox42.Hide();
            pictureBox43.Hide();
            pictureBox44.Hide();
            pictureBox45.Hide();
            pictureBox46.Hide();
            pictureBox47.Hide();
            pictureBox48.Hide();
            pictureBox49.Hide();
            pictureBox50.Hide();
            pictureBox52.Hide();
            pictureBox53.Hide();
            pictureBox54.Hide();
            pictureBox55.Hide();
            pictureBox56.Hide();
            pictureBox57.Hide();
            pictureBox58.Hide();
            pictureBox59.Hide();
            BookmarkList.Hide();
            BookmarkSet.Hide();
            BookmarkLabel.Hide();
            BookmarkImage.Hide();
            SubtractBookmarkButton.Hide();
            SubtractBookmarkButton.Hide();
        }

        internal void PersonalizationLabel_Click_1(object sender, EventArgs e)
        {
            PersonalizationLabel.Show();
            PersonalizationImage.Show();
            HomePageLabel.Show();
            HomeSet.Show();
            ColorLabel.Show();
            pictureBox11.Show();
            pictureBox12.Show();
            pictureBox13.Show();
            pictureBox14.Show();
            pictureBox15.Show();
            pictureBox16.Show();
            pictureBox17.Show();
            pictureBox18.Show();
            pictureBox19.Show();
            pictureBox20.Show();
            pictureBox21.Show();
            pictureBox22.Show();
            pictureBox23.Show();
            pictureBox24.Show();
            pictureBox25.Show();
            pictureBox26.Show();
            pictureBox27.Show();
            pictureBox28.Show();
            pictureBox29.Show();
            pictureBox30.Show();
            pictureBox31.Show();
            pictureBox32.Show();
            pictureBox33.Show();
            pictureBox34.Show();
            pictureBox35.Show();
            pictureBox36.Show();
            pictureBox37.Show();
            pictureBox38.Show();
            pictureBox39.Show();
            pictureBox41.Show();
            pictureBox42.Show();
            pictureBox43.Show();
            pictureBox44.Show();
            pictureBox45.Show();
            pictureBox46.Show();
            pictureBox47.Show();
            pictureBox48.Show();
            pictureBox49.Show();
            pictureBox50.Show();
            pictureBox52.Show();
            pictureBox53.Show();
            pictureBox54.Show();
            pictureBox55.Show();
            pictureBox56.Show();
            pictureBox57.Show();
            pictureBox58.Show();
            pictureBox59.Show();
            BookmarkList.Hide();
            BookmarkSet.Hide();
            SubtractBookmarkButton.Hide();
        }

        internal void BookmarkLabel_Click_1(object sender, EventArgs e)
        {
            HomePageLabel.Hide();
            HomeSet.Hide();
            ColorLabel.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
            pictureBox23.Hide();
            pictureBox24.Hide();
            pictureBox25.Hide();
            pictureBox26.Hide();
            pictureBox27.Hide();
            pictureBox28.Hide();
            pictureBox29.Hide();
            pictureBox30.Hide();
            pictureBox31.Hide();
            pictureBox32.Hide();
            pictureBox33.Hide();
            pictureBox34.Hide();
            pictureBox35.Hide();
            pictureBox36.Hide();
            pictureBox37.Hide();
            pictureBox38.Hide();
            pictureBox39.Hide();
            pictureBox41.Hide();
            pictureBox42.Hide();
            pictureBox43.Hide();
            pictureBox44.Hide();
            pictureBox45.Hide();
            pictureBox46.Hide();
            pictureBox47.Hide();
            pictureBox48.Hide();
            pictureBox49.Hide();
            pictureBox50.Hide();
            pictureBox52.Hide();
            pictureBox53.Hide();
            pictureBox54.Hide();
            pictureBox55.Hide();
            pictureBox56.Hide();
            pictureBox57.Hide();
            pictureBox58.Hide();
            pictureBox59.Hide();
            BookmarkList.Hide();
            BookmarkSet.Hide();
            BookmarkLabel.Hide();
            BookmarkImage.Hide();
            BookmarkList.Show();
            BookmarkSet.Show();
            BookmarkLabel.Show();
            BookmarkImage.Show();
            SubtractBookmarkButton.Show();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            CloseButton.Visible = false;
            ((WebSpace)f).CloseSide();
        }

        public void Open()
        {
            CloseButton.Visible = true;
        }

        private void ApplyColorFromPicBox(object sender, EventArgs e)
        {
            var origin = (PictureBox)sender;
            ApplyColorToForm(origin.BackColor);
        }

        private void ApplyColorToForm(Color color)
        {
            f.BackColor = color;
        }
    }
}
