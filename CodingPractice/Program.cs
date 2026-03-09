using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");
/*
// 1-1. 기본 개념
object obj = "Hello";

if (obj is string s)  
{
    Console.WriteLine(s.Length); 
}

// 1-2. is 연산자와 타입 패턴
object objint = 42;
if (objint is int i)
{
    Console.WriteLine($"정수값: {i}");
    Console.WriteLine($"제곱: {i * i}");
}
else
{
    Console.WriteLine($"정수가 아님");
}



// 1-3. switch 문에서의 타입 패턴
PrintInfo(100);
PrintInfo(3.14);
PrintInfo("Hellow");
PrintInfo(true);
PrintInfo(DateTime.Now);


void PrintInfo(object obj)
{
    switch (obj)
    {
        case int i:
            Console.WriteLine($"정수: { i}, 2배: { i*2}");
        break;

        case double d:
        Console.WriteLine($"실수: { d}");
        break;

        case string s:
            Console.WriteLine($"문장열: {s},길이. {s.Length}");
        break;

        case bool b:
            Console.WriteLine($"불리언: {b}");
            break;

         default:
         Console.WriteLine($"기타 타입: {obj.GetType().Name}");
         break;
 
   }
       
}




// 2. 상수 패턴
CheckValue(0);
CheckValue("Hello");
CheckValue(null);
CheckValue(42);

void CheckValue(object obj)
{
    if (obj is 0)
    {
        Console.WriteLine($"값이 0임");
        return;
    }
    else if (obj is "Hello")
    {
        Console.WriteLine($"값이 Hello임");
        return;
    }
    else if (obj is null)
    {
        Console.WriteLine($"값이 null임");
        return;
    }
    else
    {
        Console.WriteLine($"다른 값 {obj}");
    }

}



// 3-1. 기본 문법


Console.WriteLine(GetDayType(DayOfWeek.Monday));
Console.WriteLine(GetDayType(DayOfWeek.Saturday));

string GetDayType(DayOfWeek day) => day switch
{
    DayOfWeek.Saturday => "주말",
    DayOfWeek.Sunday => "주말",
    _ => "평일"  
};


// 3-2. switch 식과 타입 패턴
Console.WriteLine(DescribeValue(42));
Console.WriteLine(DescribeValue(3.14));
Console.WriteLine(DescribeValue("Hello"));
Console.WriteLine(DescribeValue(null));
Console.WriteLine(DescribeValue(true));



string DescribeValue(object obj) => obj switch
{
    int i => $"정수{i}",
    double d =>$"실수{d}",
    string s =>$"문자열 \"Hello\"",
    null => "null 값",
    _ => "알 수 없는 타입 (Boolean)"
};


// 4-1. 성적 등급

Console.WriteLine($"95점: {GetGrade(95)}");
Console.WriteLine($"85점: {GetGrade(85)}");
Console.WriteLine($"75점: {GetGrade(75)}");
Console.WriteLine($"65점: {GetGrade(65)}");
Console.WriteLine($"55점: {GetGrade(55)}");


string GetGrade(int score) => score switch
{
    >90=> "A",
    > 80=> "B",
    > 70 => "C",
    > 60 => "D",
    _ => "F"

};



// 4-2. 온도 분류
Console.WriteLine($"-5도: {ClassifyTemperature(-5)}");
Console.WriteLine($"5도: {ClassifyTemperature(5)}");
Console.WriteLine($"15도: {ClassifyTemperature(15)}");
Console.WriteLine($"25도: {ClassifyTemperature(25)}");
Console.WriteLine($"35도: {ClassifyTemperature(35)}");



string ClassifyTemperature(int celsius) => celsius switch
{
    < 0=> "영하",
    < 10=>"추움",
    < 20 => "선선함",
    < 30 => "따뜻함",
    _=>"더움"
};


// 5-1. and 패턴
Console.WriteLine($"25살 유효한 나이:{IsValidAge(25)}");
Console.WriteLine($"-5살 유효한 나이:{IsValidAge(-5)}");
Console.WriteLine($"15살 청소년:{IsTeenager(15)}");
Console.WriteLine($"25살 청소년:{IsTeenager(25)}");

bool IsValidAge(int age) => age is >= 0 and <= 150;
bool IsTeenager(int age) => age is >= 13 and <= 19;

// 5-2. or 패턴

Console.WriteLine($"토요일 주말: {IsWeekend(DayOfWeek.Saturday)}");
Console.WriteLine($"월요일 주말: {IsWeekend(DayOfWeek.Monday)}");
Console.WriteLine($"'a' 모음: {IsVowel('a')}");
Console.WriteLine($"'b' 모음: {IsVowel('b')}");

bool IsWeekend(DayOfWeek day) => day is DayOfWeek.Saturday or DayOfWeek.Sunday;

bool IsVowel(char c) => c is 'a' or 'i' or 'u' or 'e' or 'o';

// 5-3. not 패턴
Console.WriteLine($"\"Hello\" not null: {IsNotNull("Hello")}");
Console.WriteLine($"\"Hello\" not null: {IsNotNull(null)}");
Console.WriteLine($"\"Hi\" not null: {IsNotEmpty("Hi")}");
Console.WriteLine($"\"\" not null: {IsNotEmpty("")}");


bool IsNotNull(object obj)=> obj is not null;
bool IsNotEmpty(string s)=> s is not "";



// 5-4. 복합 패턴

Console.WriteLine($"0: {ClassifyNumber(0)}");
Console.WriteLine($"0: {ClassifyNumber(5)}");
Console.WriteLine($"0: {ClassifyNumber(42)}");
Console.WriteLine($"0: {ClassifyNumber(-3)}");
Console.WriteLine($"0: {ClassifyNumber(100)}");
Console.WriteLine($"0: {ClassifyNumber(-50)}");

string ClassifyNumber(int n) => n switch
{
    0 => "영",
    > 0 and < 10 => "한 자리 양수",
    > 10 and < 100 => "두 자리 양수",
    < 0 and > -10 => "한 자리 음수",
    _ => "그 외"
};



// 6. var 패턴
Console.WriteLine($"Janet: {IsJanetOrJohn("Janet")}");
Console.WriteLine($"john: {IsJanetOrJohn("john")}");
Console.WriteLine($"Mike: {IsJanetOrJohn("Mike")}");

bool IsJanetOrJohn(string name) => name.ToUpper() is 
    var upper && (upper == "JANET" || upper == "JOHN");


// 7-1. 기본 사용법

var people = new Person[]
{
    new Person { Name = "철수", Age = 15 },
    new Person { Name = "영희", Age = 30 },
    new Person { Name = "할머니", Age = 70 }
};

foreach (var p in people)
{
Console.WriteLine($"{p.Name}({p.Age}세): {DescribePerson(p)}");
}

string DescribePerson(Person p) => p switch
{
{ Age: < 18 } => "미성년자",
{ Age: >= 18, Age: < 65 } => "성인",
{ Age: >= 65 } => "노인",
_ => "알 수 없음"
};

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}



// 7-2. 프로퍼티 패턴과 변수 할당

Console.WriteLine(Greet(new Person { Name = "철수", Age = 15 }));
Console.WriteLine(Greet(new Person { Name = "영희", Age = 30 }));

string Greet(Person p) => p switch
{
    { Name: var name, Age: < 18 } => $"안녕, {name}!",
    { Name: var name, Age: >= 18 } => $"안녕하세요, {name}님",
    _ => "안녕하세요"
};
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


// 7-3. 타입 패턴과 프로퍼티 패턴 결합

Person[] people = new Person[]
{
    new Student { Name = "철수", Age = 17, School = "서울고" },
    new Employee { Name = "영희", Age = 28, Company = "삼성" },
    new Person { Name = "민수", Age = 40 }
};

foreach (var p in people)
{
Console.WriteLine($"{p.Name}: {DescribeDetailed(p)}");
}

string DescribeDetailed(Person p) => p switch
{
Student { School: var school, Age: var age } =>
    $"{age}세 학생, {school} 재학",
Employee { Company: var company, Age: var age } =>
    $"{age}세 직장인, {company} 근무",
{ Age: var age } =>
    $"{age}세 일반인",
_ => "정보 없음"
};
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Student : Person
{
    public string School { get; set; }
}

class Employee : Person
{
    public string Company { get; set; }
}
// 8-1. 좌표 분류



// 8-2. 계절과 시간대



// 9-1. 기본 when 절

int[] numbers = { 0, 4, 7, -6, -3 };
foreach (int n in numbers)
{
    Console.WriteLine($"{n}: {DescribeNumber(n)}");
}

string DescribeNumber(int n) => n switch
{
    0 => "영",
    > 0 when n % 2 == 0 => "양의 짝수",
    > 0 when n % 2 == 1 => "양의 홀수",
    < 0 when n % 2 == 0 => "음의 짝수",
    < 0 when n % 2 == -1 => "음의 홀수",
    _ => "알 수 없음"
};

// 9-2. when 절과 프로퍼티 패턴
var products = new Product[]
{
    new Product { Name = "마우스", Price = 25000, Stock = 0 },
    new Product { Name = "키보드", Price = 80000, Stock = 5 },
    new Product { Name = "모니터", Price = 300000, Stock = 20 },
    new Product { Name = "USB", Price = 5000, Stock = 100 }
};

foreach (var p in products)
{
    Console.WriteLine($"{p.Name}: {GetProductStatus(p)}");
}

string GetProductStatus(Product p) => p switch
{
    { Stock: 0 } => "품절",
    { Stock: < 10 } when p.Price > 10000 => "재고 부족 (고가 상품)",
    { Stock: < 10 } => "재고 부족",
    { Price: > 50000 } => "프리미엄 상품",
    _ => "일반 상품"
	};

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

*/
// 10. 실전 예제: 게임 캐릭터 상태 판정

var characters = new Character[]
{
    new Character { Health = 0, Mana = 50, IsInCombat = false },
    new Character { Health = 15, Mana = 30, IsInCombat = true },
    new Character { Health = 50, Mana = 0, IsInCombat = true },
    new Character { Health = 90, Mana = 85, IsInCombat = false },
    new Character { Health = 60, Mana = 40, IsInCombat = true }
};

for (int i = 0; i < characters.Length; i++)
{
    var c = characters[i];
    Console.WriteLine($"캐릭터{i + 1} (HP:{c.Health}, MP:{c.Mana}): {GetCharacterStatus(c)}");
}

string GetCharacterStatus(Character c) => c switch
{
    { Health: 0 } => "사망",
    { Health: <= 20, IsInCombat: true } => "위험! 즉시 회복 필요",
    { Health: <= 20 } => "체력 낮음",
    { Mana: 0, IsInCombat: true } => "마나 고갈 - 물리 공격만 가능",
    { Health: >= 80, Mana: >= 80 } => "최상의 상태",
    { IsInCombat: true } => "전투 중",
    _ => "일반"
};

class Character
{
    public int Health { get; set; }
    public int Mana { get; set; }
    public bool IsInCombat { get; set; }
}
