

DateTime currentDate = DateTime.UtcNow; // {7/21/2016 7:23:15 PM}
DateTime Date = DateTime.Now; // {7/21/2016 7:23:15 PM}

string dateTimeString = currentDate.ToString("dd-MM-yyyy HH:mm:ss"); // "21-07-2016 19:23:15"
var t = String.Format("{0:t}", currentDate); // "6:50 PM"                             ShortTime
var d = String.Format("{0:d}", currentDate); // "8/1/2016"                            ShortDate
var T = String.Format("{0:T}", currentDate); // "6:50:23 PM"                          LongTime
var D = String.Format("{0:D}", currentDate); // "Monday, August 1, 2016"              LongDate
var f = String.Format("{0:f}", currentDate); // "Monday, August 1, 2016 6:50 PM"      LongDate+ShortTime
var F = String.Format("{0:F}", currentDate); // "Monday, August 1, 2016 6:50:23 PM"   FullDateTime
var g = String.Format("{0:g}", currentDate); // "8/1/2016 6:50 PM"                    ShortDate+ShortTime
var G = String.Format("{0:G}", currentDate); // "8/1/2016 6:50:23 PM"                 ShortDate+LongTime
var m = String.Format("{0:m}", currentDate); // "August 1"                            MonthDay
var y = String.Format("{0:y}", currentDate); // "August 2016"                         YearMonth
var r = String.Format("{0:r}", currentDate); // "SMon, 01 Aug 2016 18:50:23 GMT"      RFC1123
var s = String.Format("{0:s}", currentDate); // "2016-08-01T18:50:23"                 SortableDateTime
var u = String.Format("{0:u}", currentDate); // "2016-08-01 18:50:23Z"    



var year = String.Format("{0:y yy yyy yyyy}", currentDate); // "16 16 2016 2016"  year
var month = String.Format("{0:M MM MMM MMMM}", currentDate); // "8 08 Aug August"  month
var day = String.Format("{0:d dd ddd dddd}", currentDate); // "1 01 Mon Monday"  day
var hour = String.Format("{0:h hh H HH}", currentDate); // "6 06 18 18"       hour 12/24
var minute = String.Format("{0:m mm}", currentDate); // "50 50"            minute
var secound = String.Format("{0:s ss}", currentDate); // "23 23"            second
var fraction = String.Format("{0:f ff fff ffff}", currentDate); // "2 23 230 2300"    sec.fraction
var fraction2 = String.Format("{0:F FF FFF FFFF}", currentDate); // "2 23 23 23"       without zeroes
var period = String.Format("{0:t tt}", currentDate); // "P PM"             A.M. or P.M.
var zone = String.Format("{0:z zz zzz}", currentDate); // "+0 +00 +00:00"    time zone


DateTime today = DateTime.Now;
DateTime answer = today.AddDays(36); // Add days gün ekleme;
DateTime answer1 = today.AddHours(36); 
DateTime answer2 = today.AddMicroseconds(36); 
DateTime answer3 = today.AddMinutes(36); 
DateTime answer4 = today.AddMonths(36); 
Console.WriteLine("Today: {0:dddd}", today);
Console.WriteLine("36 days from today: {0:dddd}", answer);

// Converts the string representation of a date and time to its DateTime equivalent
var dateTime = DateTime.Parse("14:23 22 Jul 2016");
Console.WriteLine(dateTime.ToString());


DateTime parseTime = DateTime.Parse("14:23 22 Jul 2016");


// Türkiye'nin saat dilimini al
TimeZoneInfo turkeyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");

// Geçerli tarihi ve saati al
DateTime currentDateTime = DateTime.Now;

// Türkiye'nin saat dilimine göre tarihi ve saati al
DateTime turkeyDateTime = TimeZoneInfo.ConvertTime(currentDateTime, TimeZoneInfo.Local, turkeyTimeZone);

// Sonuçları yazdır
Console.WriteLine("Türkiye Saat Dilimi: " + turkeyTimeZone.DisplayName);
Console.WriteLine("Türkiye'deki Geçerli Tarih ve Saat: " + turkeyDateTime);


// Calculate what day of the week is 36 days from this instant.

DateTime time  = DateTime.UtcNow;
DateTime time2 = time.AddMonths(1);
TimeSpan duration = time2- time;


duration -= TimeSpan.FromDays(10);
 
Console.WriteLine(duration);
