using QRCoder;
using AssemblyTutorial.Shared;

QRCodeGenerator generator = new QRCodeGenerator();
QRCodeData qrCodeData = generator.CreateQrCode( "Hello World", QRCodeGenerator.ECCLevel.Q );

QRCoder.BitmapByteQRCode bitmapByteQRCode = new BitmapByteQRCode( qrCodeData );

byte[] bytes = bitmapByteQRCode.GetGraphic( 20 );
using ( FileStream fs = new FileStream( @"Test.bmp", FileMode.Create ) )
{
    fs.Write( bytes, 0, bytes.Length );
}