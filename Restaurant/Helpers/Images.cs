using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.Helpers
{
    internal class Images
    {

        public static void upload(PictureBox pb)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagenes |*.png;*.jpeg;*.jpg";
                ofd.FilterIndex = 3;
                ofd.Title = "Seleccion de foto";
                if (DialogResult.OK == ofd.ShowDialog())
                {
                    pb.Image = Image.FromFile(ofd.FileName);
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                }
            };
        }

        public static void noImage(PictureBox pb)
        {
            pb.Image = Properties.Resources.no_image64;
        }


    }
}
