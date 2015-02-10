/*Task 09. Write a function for extracting all email addresses from given text. All substrings that match
the format <identifier>@<host>…<domain> should be recognized as emails. Return the emails as array of strings.*/

var str = 'Можеш да се свържеш с нас по всяко време през чат-системата ни.\nАко предпочиташ друг начин за връзка, използвай контактите по-долу:\n    Телефон: 0884/900004\n    sales@ozone.bg - за въпроси, свързани с поръчки на продукти:\n    support@ozone.bg –  за въпроси или проблеми, свързани със сайта или допълнителна информация за продукти\n    contacts@ozone.bg – за всичко останало';

console.log(str.match(/[\w\+\-\.]+@[\w\+\-\.]+\.[\w\+\-\.]+/g));
