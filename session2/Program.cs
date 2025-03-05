using System.Text.RegularExpressions;
namespace session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ: 40+ Extention Methods
            // LINQ: 13 Category

            #region Filtration-Operator (where&OfType)

            // 1- Filteration  Operators - Where / OfType [Differed Execution Way]

            // All Product Out Stock

            // Fluent Syntax
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            // Query Syntax [Query Expression]
            //var Result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            // Fluent Syntax
            //var Result = ProductList.Where(P => P.Category == "Meat/Poultry");

            //Query Syntax[Query Expression]
            //var Result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;

            // Fluent Syntax
            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.Category == "Meat/Poultry");
            //var Result = ProductList.Where(P => P.UnitsInStock > 0 &&  P.Category == "Meat/Poultry");


            // Query Syntax [Query Expression]
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;

            // Indexed Where Valid Only in Fluent Syntax
            //Can't Be Written Using Query Syntax
            //var Result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var Result = ProductList.Where((P, Index) => Index < 5);
            //var Result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Where((P, I) => I < 5);

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ali", "omar", 1.3, 1.5, 1.5f, 1.7f, 1.9m, 10.8m, ProductList[0], ProductList[1] };

            // where based on value condition
            // OfType based on Type

            //var Result = arrayList.OfType<float>();
            //var Result = arrayList.OfType<int>();
            //var Result = arrayList.OfType<Product>();


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Transformation-Operators (Select,SelectMany)
            // 2.Transformation Operators - Select / SelectMany

            // Fluent Syntax
            //var result = ProductList.Select(P => P);
            //var result = ProductList.Select(P => P.ProductName);

            // Query Syntax [Query Expression]
            //var result = from P in ProductList
            //             select P.ProductName;

            // Fluent Syntax
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //                        .Select(P => new
            //                        {
            //                            P.ProductName,
            //                            P.Category,
            //                            OldPrice = P.UnitPrice,
            //                            NewPrice = P.UnitPrice - P.UnitPrice * 0.1m
            //                        });

            // Query Syntax [Query Expression]
            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1m
            //             };

            //var result = CustomerList.Select(C => C.CustomerName);
            //var result = CustomerList.Select(C => C.Orders); // If One Of The Property is Sequence this line will return namespace

            // Fluent Syntax
            //var result = CustomerList.SelectMany(C => C.Orders); // If One Of The Property is Sequence Must use Select many

            // Query Syntax [Query Expression]
            //var result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            // Indexed Select Valid Only In Fluent Syntax
            //Can't Be Written using Query Syntax [Query Expression]
            //var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ordering-Operators
            // 3. Ordering Operators

            // Sorting

            //var result = ProductList.OrderBy(P => P.UnitPrice);
            //var result = ProductList.OrderBy(P => P.UnitPrice).Select(P => new { P.ProductName, P.UnitPrice });

            // Default behavior is Ascending
            //var result = ProductList.OrderBy(P => P.UnitsInStock)
            //                      .Select(P => new
            //                      {
            //                          P.ProductName,
            //                          P.UnitPrice,
            //                          P.UnitsInStock
            //                      });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                      .ThenBy(P => P.UnitPrice)
            //                      .Select(P => new
            //                      {
            //                          P.ProductName,
            //                          P.UnitPrice,
            //                          P.UnitsInStock
            //                      });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                      .Select(P => new
            //                      {
            //                          P.ProductName,
            //                          P.UnitPrice,
            //                          P.UnitsInStock
            //                      });

            //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                      .ThenByDescending(P=>P.UnitPrice)
            //                      .Select(P => new
            //                      {
            //                          P.ProductName,
            //                          P.UnitPrice,
            //                          P.UnitsInStock
            //                      });

            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             orderby P.UnitPrice, P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //var result=ProductList.Reverse<Product>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Element Operator(Immediate-Execution)
            // 4. Elements Operators -Immediate Execution

            //ProductList = new List<Product>();
            //var result = ProductList.First();// May Throw Exeption [Sequence Contains no elements]
            //var result = ProductList.Last();// May Throw Exeption [Sequence Contains no elements]

            //var result = ProductList.First(P=>P.UnitsInStock==10000);// May Throw Exeption [Sequence Contains no elements]
            //var result = ProductList.Last(P=>P.UnitsInStock==10000);// May Throw Exeption [Sequence Contains no elements]

            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() { ProductName = "default product" });
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "default product" });

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "default product" });
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "default product" });


            //var result = ProductList.ElementAt(0);//May throw Exception [Index was Out Of range]
            //var result = ProductList.ElementAtOrDefault(0);

            //ProductList = new List<Product>() { new Product() { ProductName = "Only One" } };
            //var result = ProductList.Single(); // May Throw Exception
            // Sequance Contains more than one element
            // Sequance Contains No elements
            //var result = ProductList.Single(P=>P.UnitsInStock==0); // May Throw Exception
            // Sequance Contains more than one element
            // Sequance Contains No Matching elements


            //var result = ProductList.SingleOrDefault(new Product() { ProductName="Default Value"}); // May Throw Exception
            // Sequance Contains more than one element
            // Return Default Value [null] if The Sequence is Empty


            //var result = ProductList.SingleOrDefault(P=>P.UnitsInStock==0,new Product() { ProductName="Default Value"}); // May Throw Exception
            //var result = ProductList.SingleOrDefault(P=>P.ProductID==1,new Product() { ProductName="Default Value"}); // May Throw Exception
            //var result = ProductList.SingleOrDefault(P=>P.ProductID==1000,new Product() { ProductName="Default Value"}); // May Throw Exception
            // Sequance Contains more than one element
            // Return Default Value [new Product() { ProductName = "default Value" }] if The Sequence is Empty


            //var result = ProductList.DefaultIfEmpty(new Product() { ProductName = "Default" });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(result?.ProductName??"NA");
            #endregion

            #region Aggregate Operators[Immediate Execution]
            // 5. Aggregate Operators - Immediate Execution
            // Count - Sum -Max-Min-Avg

            //var result = ProductList.Count();//77
            //var result = ProductList.Count;//77 as list it has Count Property
            //var result = ProductList.Count(P => P.UnitsInStock == 0);//5
            //var result = ProductList.Where(P => P.UnitsInStock == 0).Count();//5

            // Sum

            //var result = ProductList.Sum(P => P.UnitPrice);//2222.7100
            //var result = ProductList.Sum(P => P.UnitsInStock);//3180

            // Avg

            //var result = ProductList.Average(P => P.UnitPrice);//28.866

            // Max

            //var result = ProductList.Max();//$263.50, Based on Icompareable (Price)
            //var result = ProductList.Max(new ProductComparerUnitInStock());//$263.50, Based on Icompareable (Price)
            //var result = ProductList.Max(P=>P.UnitPrice);//$263.50, Based on Icompareable (Price)
            //var result = ProductList.Max(P=>P.UnitsInStock);//125, Based on Icompareable (UnitsInStock)

            //var result = ProductList.Max(P=>P.UnitPrice);//$263.50, Based on Icompareable (Price)

            //var result = ProductList.MaxBy(P=>P.UnitPrice);//return Product that has heigest price

            // Min

            //var result = ProductList.Min();
            //var result = ProductList.Min(new ProductComparerUnitInStock());
            //var result = ProductList.Min(new ProductComparerNameLength());
            //var result = ProductList.Max(new ProductComparerNameLength());

            //var result = ProductList.Min(P=>P.UnitPrice);//2.5000
            //var result = ProductList.MinBy(P=>P.ProductName,new ProductComparerNameLength());//2.5000 return Product that has lowest price
            //var result = ProductList.MaxBy(P=>P.ProductName,new ProductComparerNameLength());//2.5000


            // Aggregate
            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Omar", "Osama" };
            //var result = Names.Aggregate((S01, S02) => $"{S01} {S02}");
            #endregion

            #region Casting Operators[Immediate Execution]
            // 6.Casting Operator - Immediate Execution

            //List<Product> list =(List<Product>) ProductList.Where(P => P.UnitsInStock == 0);// InValid
            //List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long,Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P=>P.ProductID);
            //HashSet<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Generation Operators
            // 7. Generation Operators
            // The Only Way To Call This Method As -> Class Member Method Throught "Enumerable" Class

            // Range , Empty,Repeat

            //var result = Enumerable.Range(1, 100);
            //var result = Enumerable.Empty<Product>().ToList();

            //result.Add(new Product() { ProductName = "product01" });
            //result.Add(new Product() { ProductName = "product02" });

            //var result = Enumerable.Repeat(ProductList[0], 3);
            //var result = Enumerable.Repeat(1, 3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Set Operators
            // 8. Set Operators - union Family
            // Union - union All - Intersect, Except

            //var Seq01 = Enumerable.Range(1, 100);//1....100
            //var Seq02 = Enumerable.Range(50, 100);//50....149

            //var result = Seq01.Union(Seq02); // Like Union In Sql Without Duplication
            //var result = Seq01.Concat(Seq02); // Like Union All In Sql Without Duplication

            //result = result.Distinct(); // Remove Duplication

            //var result = Seq01.Intersect(Seq02);// 50 .... 100
            //var result = Seq01.Intersect(Seq02); // 1.. 49
            //var result = Seq02.Intersect(Seq01); // 101 ... 149

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Quantifier Operators
            // 9. Quantifiers Operators - Return Boolean
            // Any -All- SequenceEqual - Contains

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(1, 100);

            // Any() --> Return  True if There Are At Least One Element [In Sequence Or MAtch The Condition]
            //var result = Seq01.Any();
            //var result = Seq01.Any(N=>N==0);

            //ProductList = new List<Product>();
            //var result = ProductList.Any();
            //var result = ProductList.Any(P => P.UnitsInStock == 0);

            //All()--> Return True if All Element in The Sequence Match The Condition Or Sequence is Empty

            //var result = ProductList.All(P => P.UnitsInStock == 0);
            //var result = ProductList.All(P => P.UnitPrice > 0);

            // SequenceEqual()
            // return true if the two Sequence are the same values and same length
            //var result = Seq01.SequenceEqual(Seq02);

            //var result = Seq02.Contains(1);
            //Console.WriteLine(result);
            #endregion

            #region Zip Operator
            // 10. Zipping Operators
            // Zip
            //List<int> Numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };
            //List<string> Words = new List<string>() { "Ten", "Twenty", "Thirty", "Fourty" };

            //var result = Words.Zip(Numbers, (W, N) => $"{N} --> {W}");
            ////var result = Words.Zip(Numbers, (W, N) => new { Number = N, Word = W });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Grouping Operators
            // Grouping Operators

            //var result = ProductList.GroupBy(P => P.Category);
            //result = from P in ProductList
            //         group P by P.Category;


            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //           into Category
            //             where Category.Count() > 10
            //             select Category;

            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var item1 in Category)
            //    {
            //        Console.WriteLine($"....{item1}");
            //    }
            //}

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //           into Category
            //             where Category.Count() > 10
            //             select new { CategoryName = Category.Key, CountOfCategory = Category.Count() };

            //var result = ProductList.Where(P => P.UnitsInStock > 0)
            //            .GroupBy(P => P.Category)
            //            .Where(C => C.Count() > 5)
            //            .Select(C => new { CategoryName = C.Key, CountOfCategory = C.Count() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Partitioning operators
            // Partitioning Operators-Take,TakeLast,Skip,Skiplast,TakeWhile,SkipWhile
            // we use it in pagination
            //var result = ProductList.Where(P=>P.UnitsInStock==0).Take(5); // Take first 5 element
            //var result = ProductList.TakeLast(5);// Take Last 5 element

            //var result = ProductList.Skip(5).Take(5);//skip first 5 element then Take first 5 element

            //int[] Numbers = { 9, 6, 4, 1, 2, 3, 4, 5 };
            //var result = Numbers.TakeWhile((N) => N % 3 == 0);// Take while condition is true 
            //var result = Numbers.SkipWhile((N) => N % 3 == 0);// Skip while condition is true

            //var result = Numbers.TakeWhile((N, I) => N > I); // take while value > it's index
            //var result = Numbers.SkipWhile((N, I) => N > I); // Skip while value > it's index

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item); 
            //}
            #endregion

            #region Let&Into
            // let / into
            // aeoiuAEOIU

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Mona", "Aya", "Mona" };

            //var result = from Name in Names
            //             select Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty);

            // if u want to filterate the result
            // 1-with into keyword
            //var result = from Name in Names
            //             select Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)
            //             into NoVolName
            //             // into : Restart Query With Introducing New Range Variable (NoVolName)
            //             where NoVolName.Length > 3
            //             select NoVolName;

            // 2- with let keyword

            //var result = from Name in Names
            //             let NoVolName = Regex.Replace(Name, "[aeoiuAEOIU]", string.Empty)
            //             // let : continue Query With Adding New Range Variable (NoVolName)
            //             where NoVolName.Length > 3
            //             select NoVolName;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = Regex.Replace("Ahmed", "[aeoiuAEOIU]", string.Empty);
            //Console.WriteLine(result);
            #endregion
        }
    }
}
