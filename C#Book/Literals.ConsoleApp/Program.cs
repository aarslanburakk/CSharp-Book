


uint ui = 4000;
Console.WriteLine(ui);
// ifadesinde, ui adlı bir değişken uint türünde tanımlanır ve bu değişkene 5 değeri atanır. Sonundaki "U" veya "u" harfi, bu sayının unsigned (işaretsiz) olduğunu belirtir.
// C#'da uint literalleri, sonuna "U" veya "u" eklenerek veya uint veri türü sınırları içindeki bir tam sayı değeri kullanılarak tanımlanabilir. Bu, C#'ın dil özelliklerinden biridir ve özellikle bellek kullanımı ve matematiksel işlemler için faydalıdır.
// Yani, uint türü 0 ile 4294967295 arasında (dahil) değer alabilir.



int a = 0;
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine(a);
Console.WriteLine(max);
Console.WriteLine(min);
//C#'da, int bir tam sayı veri türüdür ve "integer"ın kısaltmasıdır. int, genellikle imzalı bir tamsayıyı temsil etmek için kullanılır, yani hem pozitif hem de negatif tam sayıları içerebilir.

// int türü, genellikle bellekte 4 byte (32 bit) yer kaplar ve bu nedenle yaklaşık olarak -2147483648 milyar ile 2147483647 milyar arasındaki değerleri temsil edebilir.


byte b = 127;

// Bu durumda, byte C#'da bir veri türüdür ve genellikle 8 bitlik imzalı olmayan (unsigned) tamsayıları temsil etmek için kullanılır. byte, 0 ile 255 arasındaki değerleri alabilir.

// Ancak, 127 bir int türündedir ve byte'a otomatik olarak dönüştürülmez çünkü byte'ın aralığı 0 ile 255 arasındadır. Dolayısıyla, bu durumda bir derleme hatası alabilirsiniz. byte türünde bir değişkene int türünden bir değer atanırken açıkça dönüşüm yapılması gerekmektedir.

short s = 127;


// Bu durumda, short C#'da bir veri türüdür ve genellikle kısa tamsayıları temsil etmek için kullanılır. short, genellikle 16 bitlik bir tamsayıdır ve -32,768 ile 32,767 arasındaki değerleri alabilir.

ushort us = 127;

// Bu durumda, ushort C#'da bir veri türüdür ve "unsigned short"un kısaltmasıdır. ushort, pozitif tamsayıları temsil etmek için kullanılır ve 0'dan başlayarak 65535'e kadar olan değerleri alabilir.

sbyte sb = 127;

// Bu ifadede, sbyte C#'da bir veri türüdür ve "signed byte"ın kısaltmasıdır. sbyte, 8 bitlik bir imzalı (signed) tamsayıyı temsil eder, bu da -128 ile 127 arasındaki alabilir.

decimal m = 30.5M;
// Bu ifadede, decimal C#'da bir veri türüdür ve ondalık sayıları temsil etmek için kullanılır. decimal, yüksek hassasiyet gerektiren finansal veya hesaplamalı uygulamalarda tercih edilir.

double d = 30.5D;
// Bu ifadede, double C#'da bir veri türüdür ve kayan noktalı sayıları (ondalık sayılar) temsil etmek için kullanılır. double, genellikle yüksek hassasiyet gerektirmeyen hesaplamalarda kullanılır.

float f = 30.5F;
float maxfloat = float.MaxValue;
float minfloat = float.MinValue;
Console.WriteLine(f);
Console.WriteLine(maxfloat);
Console.WriteLine(minfloat);

// Bu ifadede, float C#'da bir veri türüdür ve kayan noktalı sayıları (ondalık sayılar) temsil etmek için kullanılır. float, genellikle daha düşük hassasiyete sahip olmasına rağmen, daha az bellek kullanımı gerektiren durumlarda double'dan daha yaygın olarak kullanılır.

long l = 5;
long maxlong = long.MaxValue;
long minlong = long.MinValue;

// Bu ifadede, long C#'da bir veri türüdür ve genellikle büyük tamsayı değerlerini temsil etmek için kullanılır. long, genellikle int'ten daha büyük aralıklarda değerler saklamak için kullanılır.


ulong ul = 5UL;
// Bu ifadede, ulong C#'da bir veri türüdür ve "unsigned long"un kısaltmasıdır. ulong, pozitif tamsayıları temsil etmek için kullanılır ve long türünden daha büyük pozitif tamsayılar saklayabilir. ulong, yalnızca pozitif değerleri temsil eder ve 0'dan başlayarak 8 byte'lık bir aralıkta değer alır.





bool val = true;
// Bu durumda, bool C#'da bir veri türüdür ve sadece iki değeri alabilir: true (doğru) veya false (yanlış). Mantıksal operasyonlar ve karar yapıları gibi durumlarda sıklıkla kullanılır.

string  valStr = "hello, this is a string literal";

string valStrOne  = $"{ul} değerini yazılabilir";

// Bu ifadede, string C#'da bir veri türüdür ve metin verilerini temsil etmek için kullanılır. string, karakter dizilerini saklamak için kullanılır ve çift tırnak içinde belirtilir.

