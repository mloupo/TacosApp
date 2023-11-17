using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace TacosApp.Objects
{
	public class Commun
	{
		public static int ROW_HEIGTH = 40;
		public byte[] ImageToByteArray(Image mImage)
		{
			if (mImage == null)
				return null;

			MemoryStream mMemoryStream = new MemoryStream();
			mImage.Save(mMemoryStream, ImageFormat.Png);
			return mMemoryStream.ToArray();
		}

		public Image BitmapToImage(Bitmap bitmap)
		{
			MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Png);
			return Image.FromStream(memoryStream);
		}
	}
}
