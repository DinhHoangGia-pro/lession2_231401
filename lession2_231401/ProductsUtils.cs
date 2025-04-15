using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lession2_231401
{
    internal class ProductsUtils
    {

        public static String category_json = @"[
  {
    'categoryID': 1,
    'categoryName': 'Beverages',
    'description': 'Soft drinks, coffees, teas, beers, and ales',
    'picture': ''
  },
  {
    'categoryID': 2,
    'categoryName': 'Condiments',
    'description': 'Sweet and savory sauces, relishes, spreads, and seasonings',
    'picture': ''
  },
  {
    'categoryID': 3,
    'categoryName': 'Confections',
    'description': 'Desserts, candies, and sweet breads',
    'picture': ''
  },
  {
    'categoryID': 4,
    'categoryName': 'Dairy Products',
    'description': 'Cheeses',
    'picture': ''
  },
  {
    'categoryID': 5,
    'categoryName': 'Grains/Cereals',
    'description': 'Breads, crackers, pasta, and cereal',
    'picture': ''
  },
  {
    'categoryID': 6,
    'categoryName': 'Meat/Poultry',
    'description': 'Prepared meats',
    'picture': ''
  },
  {
    'categoryID': 7,
    'categoryName': 'Produce',
    'description': 'Dried fruit and bean curd',
    'picture': ''
  },
  {
    'categoryID': 8,
    'categoryName': 'Seafood',
    'description': 'Seaweed and fish',
    'picture': ''
  }
]
";


        public static String supplier_json = @"[
  {
    'supplierID': 1,
    'companyName': 'Exotic Liquids',
    'contactTitle': 'Purchasing Manager',
    'address': '49 Gilbert St.',
    'city': 'London',
    'region': null,
    'postalCode': 'EC1 4SD',
    'country': 'UK',
    'phone': '(171) 555-2222',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 2,
    'companyName': 'New Orleans Cajun Delights',
    'contactTitle': 'Order Administrator',
    'address': 'P.O. Box 78934',
    'city': 'New Orleans',
    'region': 'LA',
    'postalCode': '70117',
    'country': 'USA',
    'phone': '(100) 555-4822',
    'fax': null,
    'homePage': '#CAJUN.HTM#'
  },
  {
    'supplierID': 3,
    'companyName': 'Grandma Kellys Homestead',
    'contactTitle': 'Sales Representative',
    'address': '707 Oxford Rd.',
    'city': 'Ann Arbor',
    'region': 'MI',
    'postalCode': '48104',
    'country': 'USA',
    'phone': '(313) 555-5735',
    'fax': '(313) 555-3349',
    'homePage': null
  },
  {
    'supplierID': 4,
    'companyName': 'Tokyo Traders',
    'contactTitle': 'Marketing Manager',
    'address': '9-8 Sekimai Musashino-shi',
    'city': 'Tokyo',
    'region': null,
    'postalCode': '100',
    'country': 'Japan',
    'phone': '(03) 3555-5011',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 5,
    'companyName': 'Cooperativa de Quesos Las Cabras',
    'contactTitle': 'Export Administrator',
    'address': 'Calle del Rosal 4',
    'city': 'Oviedo',
    'region': 'Asturias',
    'postalCode': '33007',
    'country': 'Spain',
    'phone': '(98) 598 76 54',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 6,
    'companyName': 'Mayumis',
    'contactTitle': 'Marketing Representative',
    'address': '92 Setsuko Chuo-ku',
    'city': 'Osaka',
    'region': null,
    'postalCode': '545',
    'country': 'Japan',
    'phone': '(06) 431-7877',
    'fax': null,
    'homePage': 'Mayumis (on the World Wide Web)'
  },
  {
    'supplierID': 7,
    'companyName': 'Pavlova, Ltd.',
    'contactTitle': 'Marketing Manager',
    'address': '74 Rose St. Moonie Ponds',
    'city': 'Melbourne',
    'region': 'Victoria',
    'postalCode': '3058',
    'country': 'Australia',
    'phone': '(03) 444-2343',
    'fax': '(03) 444-6588',
    'homePage': null
  },
  {
    'supplierID': 8,
    'companyName': 'Specialty Biscuits, Ltd.',
    'contactTitle': 'Sales Representative',
    'address': '29 Kings Way',
    'city': 'Manchester',
    'region': null,
    'postalCode': 'M14 GSD',
    'country': 'UK',
    'phone': '(161) 555-4448',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 9,
    'companyName': 'PB Knäckebröd AB',
    'contactTitle': 'Sales Agent',
    'address': 'Kaloadagatan 13',
    'city': 'Göteborg',
    'region': null,
    'postalCode': 'S-345 67',
    'country': 'Sweden',
    'phone': '031-987 65 43',
    'fax': '031-987 65 91',
    'homePage': null
  },
  {
    'supplierID': 10,
    'companyName': 'Refrescos Americanas LTDA',
    'contactTitle': 'Marketing Manager',
    'address': 'Av. das Americanas 12.890',
    'city': 'Sao Paulo',
    'region': null,
    'postalCode': '5442',
    'country': 'Brazil',
    'phone': '(11) 555 4640',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 11,
    'companyName': 'Heli Süßwaren GmbH & Co. KG',
    'contactTitle': 'Sales Manager',
    'address': 'Tiergartenstraße 5',
    'city': 'Berlin',
    'region': null,
    'postalCode': '10785',
    'country': 'Germany',
    'phone': '(010) 9984510',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 12,
    'companyName': 'Plutzer Lebensmittelgroßmärkte AG',
    'contactTitle': 'International Marketing Mgr.',
    'address': 'Bogenallee 51',
    'city': 'Frankfurt',
    'region': null,
    'postalCode': '60439',
    'country': 'Germany',
    'phone': '(069) 992755',
    'fax': null,
    'homePage': 'Plutzer (on the World Wide Web)'
  },
  {
    'supplierID': 13,
    'companyName': 'Nord-Ost-Fisch Handelsgesellschaft mbH',
    'contactTitle': 'Coordinator Foreign Markets',
    'address': 'Frahmredder 112a',
    'city': 'Cuxhaven',
    'region': null,
    'postalCode': '27478',
    'country': 'Germany',
    'phone': '(04721) 8713',
    'fax': '(04721) 8714',
    'homePage': null
  },
  {
    'supplierID': 14,
    'companyName': 'Formaggi Fortini s.r.l.',
    'contactTitle': 'Sales Representative',
    'address': 'Viale Dante, 75',
    'city': 'Ravenna',
    'region': null,
    'postalCode': '48100',
    'country': 'Italy',
    'phone': '(0544) 60323',
    'fax': '(0544) 60603',
    'homePage': '#FORMAGGI.HTM#'
  },
  {
    'supplierID': 15,
    'companyName': 'Norske Meierier',
    'contactTitle': 'Marketing Manager',
    'address': 'Hatlevegen 5',
    'city': 'Sandvika',
    'region': null,
    'postalCode': '1320',
    'country': 'Norway',
    'phone': '(0)2-953010',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 16,
    'companyName': 'Bigfoot Breweries',
    'contactTitle': 'Regional Account Rep.',
    'address': '3400 - 8th Avenue Suite 210',
    'city': 'Bend',
    'region': 'OR',
    'postalCode': '97101',
    'country': 'USA',
    'phone': '(503) 555-9931',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 17,
    'companyName': 'Svensk Sjöföda AB',
    'contactTitle': 'Sales Representative',
    'address': 'Brovallavägen 231',
    'city': 'Stockholm',
    'region': null,
    'postalCode': 'S-123 45',
    'country': 'Sweden',
    'phone': '08-123 45 67',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 18,
    'companyName': 'Aux joyeux ecclésiastiques',
    'contactTitle': 'Sales Manager',
    'address': '203, Rue des Francs-Bourgeois',
    'city': 'Paris',
    'region': null,
    'postalCode': '75004',
    'country': 'France',
    'phone': '(1) 03.83.00.68',
    'fax': '(1) 03.83.00.62',
    'homePage': null
  },
  {
    'supplierID': 19,
    'companyName': 'New England Seafood Cannery',
    'contactTitle': 'Wholesale Account Agent',
    'address': 'Order Processing Dept. 2100 Paul Revere Blvd.',
    'city': 'Boston',
    'region': 'MA',
    'postalCode': '02134',
    'country': 'USA',
    'phone': '(617) 555-3267',
    'fax': '(617) 555-3389',
    'homePage': null
  },
  {
    'supplierID': 20,
    'companyName': 'Leka Trading',
    'contactTitle': 'Owner',
    'address': '471 Serangoon Loop, Suite #402',
    'city': 'Singapore',
    'region': null,
    'postalCode': '0512',
    'country': 'Singapore',
    'phone': '555-8787',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 21,
    'companyName': 'Lyngbysild',
    'contactTitle': 'Sales Manager',
    'address': 'Lyngbysild Fiskebakken 10',
    'city': 'Lyngby',
    'region': null,
    'postalCode': '2800',
    'country': 'Denmark',
    'phone': '43844108',
    'fax': '43844115',
    'homePage': null
  },
  {
    'supplierID': 22,
    'companyName': 'Zaanse Snoepfabriek',
    'contactTitle': 'Accounting Manager',
    'address': 'Verkoop Rijnweg 22',
    'city': 'Zaandam',
    'region': null,
    'postalCode': '9999 ZZ',
    'country': 'Netherlands',
    'phone': '(12345) 1212',
    'fax': '(12345) 1210',
    'homePage': null
  },
  {
    'supplierID': 23,
    'companyName': 'Karkki Oy',
    'contactTitle': 'Product Manager',
    'address': 'Valtakatu 12',
    'city': 'Lappeenranta',
    'region': null,
    'postalCode': '53120',
    'country': 'Finland',
    'phone': '(953) 10956',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 24,
    'companyName': 'Gday, Mate',
    'contactTitle': 'Sales Representative',
    'address': '170 Prince Edward Parade Hunters Hill',
    'city': 'Sydney',
    'region': 'NSW',
    'postalCode': '2042',
    'country': 'Australia',
    'phone': '(02) 555-5914',
    'fax': '(02) 555-4873',
    'homePage': 'Gday Mate (on the World Wide Web)'
  },
  {
    'supplierID': 25,
    'companyName': 'Ma Maison',
    'contactTitle': 'Marketing Manager',
    'address': '2960 Rue St. Laurent',
    'city': 'Montréal',
    'region': 'Québec',
    'postalCode': 'H1J 1C3',
    'country': 'Canada',
    'phone': '(514) 555-9022',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 26,
    'companyName': 'Pasta Buttini s.r.l.',
    'contactTitle': 'Order Administrator',
    'address': 'Via dei Gelsomini, 153',
    'city': 'Salerno',
    'region': null,
    'postalCode': '84100',
    'country': 'Italy',
    'phone': '(089) 6547665',
    'fax': '(089) 6547667',
    'homePage': null
  },
  {
    'supplierID': 27,
    'companyName': 'Escargots Nouveaux',
    'contactTitle': 'Sales Manager',
    'address': '22, rue H. Voiron',
    'city': 'Montceau',
    'region': null,
    'postalCode': '71300',
    'country': 'France',
    'phone': '85.57.00.07',
    'fax': null,
    'homePage': null
  },
  {
    'supplierID': 28,
    'companyName': 'Gai pâturage',
    'contactTitle': 'Sales Representative',
    'address': 'Bat. B 3, rue des Alpes',
    'city': 'Annecy',
    'region': null,
    'postalCode': '74000',
    'country': 'France',
    'phone': '38.76.98.06',
    'fax': '38.76.98.58',
    'homePage': null
  },
  {
    'supplierID': 29,
    'companyName': 'Forêts dérables',
    'contactTitle': 'Accounting Manager',
    'address': '148 rue Chasseur',
    'city': 'Ste-Hyacinthe',
    'region': 'Québec',
    'postalCode': 'J2S 7S8',
    'country': 'Canada',
    'phone': '(514) 555-2955',
    'fax': '(514) 555-2921',
    'homePage': null
  }
]
        ";



        public static String product_json = @"[
     {
    'productID': 1,
    'productName': 'Bia Huda',
    'supplierID': 1,
    'categoryID': 1,
    'quantityPerUnit': '10 boxes x 20 bags',
    'unitPrice': 10000,
    'unitsInStock': 39,
    'unitsOnOrder': 0,
    'reorderLevel': 1,
    'discontinued': false
  },
  {
    'productID': 2,
    'productName': 'Bia Sài Gòn3',
    'supplierID': 1,
    'categoryID': 1,
    'quantityPerUnit': '24 - 12 oz bottles',
    'unitPrice': 19,
    'unitsInStock': 17,
    'unitsOnOrder': 40,
    'reorderLevel': 25,
    'discontinued': false
  },
  {
    'productID': 3,
    'productName': 'Bia Hà Nội',
    'supplierID': 1,
    'categoryID': 2,
    'quantityPerUnit': '12 - 550 ml bottles',
    'unitPrice': 10,
    'unitsInStock': 13,
    'unitsOnOrder': 70,
    'reorderLevel': 25,
    'discontinued': false
  },
  {
    'productID': 4,
    'productName': 'Chef Antons Cajun Seasoning',
    'supplierID': 2,
    'categoryID': 2,
    'quantityPerUnit': '48 - 6 oz jars',
    'unitPrice': 22,
    'unitsInStock': 53,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': false
  },
  {
    'productID': 5,
    'productName': 'Chef Antons Gumbo Mix',
    'supplierID': 2,
    'categoryID': 2,
    'quantityPerUnit': '36 boxes',
    'unitPrice': 21.35,
    'unitsInStock': 0,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': true
  },
  {
    'productID': 6,
    'productName': 'Grandmas Boysenberry Spread',
    'supplierID': 3,
    'categoryID': 2,
    'quantityPerUnit': '12 - 8 oz jars',
    'unitPrice': 25,
    'unitsInStock': 120,
    'unitsOnOrder': 0,
    'reorderLevel': 25,
    'discontinued': false
  },
  {
    'productID': 7,
    'productName': 'Uncle Bobs Organic Dried Pears',
    'supplierID': 3,
    'categoryID': 7,
    'quantityPerUnit': '12 - 1 lb pkgs.',
    'unitPrice': 30,
    'unitsInStock': 15,
    'unitsOnOrder': 0,
    'reorderLevel': 10,
    'discontinued': false
  },
  {
    'productID': 8,
    'productName': 'Northwoods Cranberry Sauce',
    'supplierID': 3,
    'categoryID': 2,
    'quantityPerUnit': '12 - 12 oz jars',
    'unitPrice': 40,
    'unitsInStock': 6,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': false
  },
  {
    'productID': 9,
    'productName': 'Mishi Kobe Niku111',
    'supplierID': 4,
    'categoryID': 6,
    'quantityPerUnit': '18 - 500 g pkgs.',
    'unitPrice': 97,
    'unitsInStock': 29,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': true
  },
  {
    'productID': 10,
    'productName': 'Ikura',
    'supplierID': 4,
    'categoryID': 8,
    'quantityPerUnit': '12 - 200 ml jars',
    'unitPrice': 31,
    'unitsInStock': 31,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': false
  },
  {
    'productID': 11,
    'productName': 'Queso Cabrales',
    'supplierID': 5,
    'categoryID': 4,
    'quantityPerUnit': '1 kg pkg.',
    'unitPrice': 21,
    'unitsInStock': 22,
    'unitsOnOrder': 30,
    'reorderLevel': 30,
    'discontinued': false
  },
  {
    'productID': 12,
    'productName': 'Queso Manchego La Pastora',
    'supplierID': 5,
    'categoryID': 4,
    'quantityPerUnit': '10 - 500 g pkgs.',
    'unitPrice': 38,
    'unitsInStock': 86,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': false
  },
  {
    'productID': 13,
    'productName': 'Konbu',
    'supplierID': 6,
    'categoryID': 8,
    'quantityPerUnit': '2 kg box',
    'unitPrice': 6,
    'unitsInStock': 24,
    'unitsOnOrder': 0,
    'reorderLevel': 5,
    'discontinued': false
  },
  {
    'productID': 14,
    'productName': 'Tofu11111',
    'supplierID': 6,
    'categoryID': 7,
    'quantityPerUnit': '40 - 100 g pkgs.',
    'unitPrice': 23.25,
    'unitsInStock': 35,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': false
  },
  {
    'productID': 15,
    'productName': 'Genen Shouyu',
    'supplierID': 6,
    'categoryID': 2,
    'quantityPerUnit': '24 - 250 ml bottles',
    'unitPrice': 15.5,
    'unitsInStock': 39,
    'unitsOnOrder': 0,
    'reorderLevel': 5,
    'discontinued': false
  },
  {
    'productID': 16,
    'productName': 'Pavlova',
    'supplierID': 7,
    'categoryID': 3,
    'quantityPerUnit': '32 - 500 g boxes',
    'unitPrice': 17.45,
    'unitsInStock': 29,
    'unitsOnOrder': 0,
    'reorderLevel': 10,
    'discontinued': false
  },
  {
    'productID': 17,
    'productName': 'Alice Mutton',
    'supplierID': 7,
    'categoryID': 6,
    'quantityPerUnit': '20 - 1 kg tins',
    'unitPrice': 39,
    'unitsInStock': 0,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': true
  },
  {
    'productID': 18,
    'productName': 'Carnarvon Tigers',
    'supplierID': 7,
    'categoryID': 8,
    'quantityPerUnit': '16 kg pkg.',
    'unitPrice': 62.5,
    'unitsInStock': 42,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': false
  },
  {
    'productID': 19,
    'productName': 'Teatime Chocolate Biscuits',
    'supplierID': 8,
    'categoryID': 3,
    'quantityPerUnit': '10 boxes x 12 pieces',
    'unitPrice': 9.2,
    'unitsInStock': 25,
    'unitsOnOrder': 0,
    'reorderLevel': 5,
    'discontinued': false
  },
  {
    'productID': 20,
    'productName': 'Sir Rodneys Marmalade',
    'supplierID': 8,
    'categoryID': 3,
    'quantityPerUnit': '30 gift boxes',
    'unitPrice': 81,
    'unitsInStock': 40,
    'unitsOnOrder': 0,
    'reorderLevel': 0,
    'discontinued': false
  }
  
]";

    }
}
