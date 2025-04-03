// See https://aka.ms/new-console-template for more information
using StringsUtilitys;

Console.WriteLine("Hello, World!");



//foreach (var p in Prefix.Prefixes(new string[] { "many", "manly", "men", "maybe", "my" }, 3))
//    Console.WriteLine(p);

//var a = Duplicates.DuplicatesV1([4,3,6,7,11], 8);
var a = Duplicates.DuplicatesV1([42, 959, 473, 754, 409, 622, 286, 718, 496, 437, 841, 776, 115, 812, 12, 672, 488, 914, 129, 67, 475, 589, 162, 973, 570, 105, 679, 438, 882, 588, 325, 197, 955, 279, 853, 585, 800, 925, 798, 215, 531, 924, 699], 510);
Console.WriteLine(a);
Console.ReadLine();