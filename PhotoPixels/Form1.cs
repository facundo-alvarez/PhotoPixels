namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        uint red, orange, yellow, lightGreen, green, turquoise, cyan, lightBlue, blue, violet, magenta, raspberry, grey, black, white;
        int totalPixels;
        Bitmap bitmap;
        List<Color> c;

        public Form1()
        {
            InitializeComponent();
            c = new List<Color>();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            string path;
            string fileName;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.JPG; *.JPEG)| *.JPG; *.JPEG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    
                    bitmap = (Bitmap)Image.FromFile(path);
                    totalPixels = bitmap.Width * bitmap.Height;

                    photoViewer.Image = bitmap;
                    GetMetadata(path);
                    GetPixels();
                    
                    redData.Text = PixelPercentage(red, totalPixels).ToString("0.00") + "%";
                    orangeData.Text = PixelPercentage(orange, totalPixels).ToString("0.00") + "%";
                    yellowData.Text = PixelPercentage(yellow, totalPixels).ToString("0.00") + "%";
                    lgreenData.Text = PixelPercentage(lightGreen, totalPixels).ToString("0.00") + "%";
                    greenData.Text = PixelPercentage(green, totalPixels).ToString("0.00") + "%";
                    turquoiseData.Text = PixelPercentage(turquoise, totalPixels).ToString("0.00") + "%";
                    cyanData.Text = PixelPercentage(cyan, totalPixels).ToString("0.00") + "%";
                    lblueData.Text = PixelPercentage(lightBlue, totalPixels).ToString("0.00") + "%";
                    blueData.Text = PixelPercentage(blue, totalPixels).ToString("0.00") + "%";
                    violetData.Text = PixelPercentage(violet, totalPixels).ToString("0.00") + "%";
                    magentaData.Text = PixelPercentage(magenta, totalPixels).ToString("0.00") + "%";
                    raspberryData.Text = PixelPercentage(raspberry, totalPixels).ToString("0.00") + "%";
                    blackData.Text = PixelPercentage(black, totalPixels).ToString("0.00") + "%";
                    whiteData.Text = PixelPercentage(white, totalPixels).ToString("0.00") + "%";
                    greyData.Text = PixelPercentage(grey, totalPixels).ToString("0.00") + "%";
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            red = orange = yellow = lightGreen = green = turquoise = cyan = lightBlue = blue = violet = magenta = raspberry = grey = black = white = 0;
            redData.Text = orangeData.Text = yellowData.Text = lgreenData.Text = greenData.Text = turquoiseData.Text =
                cyanData.Text = lblueData.Text = blueData.Text = violetData.Text = magentaData.Text = raspberryData.Text =
                blackData.Text = whiteData.Text = greyData.Text = widthData.Text = heightData.Text = nameData.Text = String.Empty;
            totalPixels = 0;
            if(bitmap != null)
                bitmap.Dispose();
            photoViewer.Image = null;
        }

        private void GetMetadata(string path)
        {
            widthData.Text = bitmap.Width.ToString();
            heightData.Text = bitmap.Height.ToString();
            nameData.Text = Path.GetFileNameWithoutExtension(path); ;
        }

        private void GetPixels()
        {
            for (ushort i = 0; i < bitmap.Width; i++)
            {
                for(ushort j = 0; j < bitmap.Height; j++)
                {
                    GetColors(bitmap.GetPixel(i, j));
                }
            } 
        }

        private void GetColors(Color c)
        {           
            var hue = c.GetHue();
            var sat = c.GetSaturation();
            var lum = c.GetBrightness();

            if (lum <= 0.05)
            {
                black++;
            }
            else if (lum >= 0.95 || (lum >= 0.85 && sat <= 0.10)) white++;
            else
            {
                if (sat <= 0.05) grey++;
                else
                {
                    if (hue >= 0 && hue < 10) red++;
                    if (hue >= 10 && hue < 35) orange++;
                    if (hue >= 35 && hue < 45) yellow++;
                    if (hue >= 45 && hue < 70) lightGreen++;
                    if (hue >= 70 && hue < 95) green++;
                    if (hue >= 95 && hue < 145) turquoise++;
                    if (hue >= 145 && hue < 170) cyan++;
                    if (hue >= 170 && hue < 190) lightBlue++;
                    if (hue >= 190 && hue < 250) blue++;
                    if (hue >= 250 && hue < 280) violet++;
                    if (hue >= 280 && hue < 300) magenta++;
                    if (hue >= 300 && hue < 330) raspberry++;
                    if (hue >= 330 && hue < 361) red++;
                }
            } 
        }

        private decimal PixelPercentage(uint color, int pixels)
        {
            decimal p = (color / (decimal)pixels) * 100;
            return p;
        }
    }
}