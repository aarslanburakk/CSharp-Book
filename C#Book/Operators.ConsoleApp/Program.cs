int a = 10;
int b = 5;
int sum = a + b; // Toplama operatörü
int difference = a - b; // Çıkarma operatörü
int product = a * b; // Çarpma operatörü
int quotient = a / b; // Bölme operatörü
int remainder = a % b; // Mod alma operatörü


int x = 10;
int y = 5;
bool isEqual = (x == y); // Eşitlik karşılaştırma operatörü
bool isNotEqual = (x != y); // Eşitsizlik karşılaştırma operatörü
bool isGreater = (x > y); // Büyüklük karşılaştırma operatörü
bool isLess = (x < y); // Küçüklük karşılaştırma operatörü

int num = 10; // Atama operatörü


bool condition1 = true;
bool condition2 = false;
bool result1 = condition1 && condition2; // Ve operatörü
bool result2 = condition1 || condition2; // Veya operatörü
bool result3 = !condition1; // Değil operatörü


var XT = true;
var YF = false;
var val = XT && YF; // Sonuç true döner.
var val2  = YF && XT; // Sonuç false döner (x değerlendirilmez).
var val3 = YF && YF; // Sonuç false döner (sağdaki y değerlendirilmez).    
Console.WriteLine(val2);

//  Ternary Operator

int age = 18;

string result = (age >= 18) ? "Yetişkin" : "Çocuk";
Console.WriteLine("Bu kişi bir " + result + "dur.");
age--;
age++;
// condition ? expression_if_true : expression_if_false;
// Eğer bir koşul doğru ise, bir ifadeyi değerlendir; aksi takdirde, başka bir ifadeyi değerlendir.


var type = typeof(int);
age = age + age;
age += age;
// kısaltılmış operator

var x3 = 42;
Console.WriteLine(++x3); // 43

int ab = 6; // 6 = 110 (ikili)
ab &= 3; // 3 = 011 (ikili); a = a & 3; a şimdi 2 (010 ikili)
Console.WriteLine(ab); // Çıktı: 2

int av = 6; // 6 = 110 (ikili)
av |= 3; // 3 = 011 (ikili); a = a | 3; a şimdi 7 (111 ikili)
Console.WriteLine(av); // Çıktı: 7


int abr = 3; // 3 = 011 (ikili)
abr <<= 2; // a = a << 2; a şimdi 12 (1100 ikili)
Console.WriteLine(abr); // Çıktı: 12

int at = 12; // 12 = 1100 (ikili)
at >>= 2; // a = a >> 2; a şimdi 3 (0011 ikili)
Console.WriteLine(at); // Çıktı: 3
