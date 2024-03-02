using System.Reflection.Emit;
using QRCoder;

// Katlyn Quinn
// MEID KAT2342618
// CIS262AD 10549
// Lesson 4

namespace GenerateQR
{
    public class GenQR
    {
            

        public void MakeNewQR( String AddressText )
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData qrCodeData = generator.CreateQrCode( AddressText, QRCodeGenerator.ECCLevel.Q );

            QRCoder.BitmapByteQRCode bitmapByteQRCode = new BitmapByteQRCode( qrCodeData );

            byte[] bytes = bitmapByteQRCode.GetGraphic( 20 );
            using ( FileStream fs = new FileStream( @"Address.bmp", FileMode.Create ) )
            {
                fs.Write( bytes, 0, bytes.Length );
            }

        }
        
    }
}
