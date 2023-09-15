using System.Collections;
namespace LeetCode.Tests.DemoTest;

/// <summary>
/// Демонстрационный юнит-тест. Используется для как справочник по xUnut.
/// </summary>
public class DemoTest
{
    // Тест без параметров.
    [Fact]
    [Trait("Caterogy", "Demo")] // Задаёт признаки для сортировки в списке тестов
    public void FactDemoTest()
    {
        Demo demo = new();
        var result = demo.Sum(1, 1);
        Assert.Equal(2, result);
    }

    // Тест c параметрами.
    [Theory]
    [Trait("Caterogy", "Demo")]
    [InlineData(1, 1, 2)]
    [InlineData(2, 2, 4)]
    public void TheoryInlineDataDemoTest(int a, int b, int expected)
    {
        Demo demo = new();
        var result = demo.Sum(a, b);
        Assert.Equal(expected, result);
    }

    // Тест c параметрами из внешнего класса.
    // Используется когда входные данные не константны.
    [Theory]
    [Trait("Caterogy", "Demo")]
    [ClassData(typeof(DemoTestData))]
    public void TheoryClassDataDemoTest(int a, int b, int expected)
    {
        Demo demo = new();
        var result = demo.Sum(a, b);
        Assert.Equal(expected, result);
    }

    // Тест c параметрами из статического свойства.
    // Используется когда входные данные не константны.
    [Theory]
    [Trait("Caterogy", "Demo")]
    [MemberData(nameof(Data))]
    public void TheoryMemberDataDemoTest(int a, int b, int expected)
    {
        Demo demo = new();
        var result = demo.Sum(a, b);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { 1, 1, 2 },
            new object[] { int.MinValue, 1, int.MinValue + 1 }
        };

    // Тест c параметрами из статического метода c параметром.
    [Theory]
    [Trait("Caterogy", "Demo")]
    [MemberData(nameof(Data), parameters: 2)]
    public void TheoryMemberDataParamDemoTest(int a, int b, int expected)
    {
        Demo demo = new();
        var result = demo.Sum(a, b);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> GetData(int count)
    {
        var list = new List<object[]>
        {
                new object[] { 1, 1, 2 },
                new object[] { int.MinValue, 1, int.MinValue + 1 }
        };
        return list.Take(count);
    }

    // Тест c параметрами из свойства другого класса.
    [Theory]
    [Trait("Caterogy", "Demo")]
    [MemberData(nameof(DemoTestData.Data), MemberType = typeof(DemoTestData))]
    public void TheoryMemberDataExternalDemoTest(int a, int b, int expected)
    {
        Demo demo = new();
        var result = demo.Sum(a, b);
        Assert.Equal(expected, result);
    }
}

public class DemoTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, 1, 2 };
        yield return new object[] { int.MinValue, 1, int.MinValue + 1 };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { 1, 1, 2 },
            new object[] { 2, 2, 4 }
        };
}

/* Взято с Metanit

All(collection, action): метод подтверждает, что все элементы коллекции collection соответствуют действию action

Contains(expectedSubString, actualString): метод подтверждает, что строка actualString содержит expectedSubString

DoesNotContain(expectedSubString, actualString): метод подтверждает, что строка actualString не содержит строку expectedSubString

DoesNotMatch(expectedRegexPattern, actualString): метод подтверждает, что строка actualString не соответствует регулярному выражению expectedRegexPattern

Matches(expectedRegexPattern, actualString): метод подтверждает, что строка actualString соответствует регулярному выражению expectedRegexPattern

Equal(expected, result): метод сравнивает результат теста в виде значения result и ожидаемое значение expected и подтверждает их равенство

NotEqual(expected, result): метод сравнивает результат теста в виде значения result и ожидаемое значение expected и подтверждает их неравенство

Empty(collection): метод подтверждает, что коллекция collection пустая

NotEmpty(collection): метод подтверждает, что коллекция collection не пустая

True(result): метод подтверждает, что результат теста равен true

False(result): метод подтверждает, что результат теста равен false

IsType(expected, result): метод подтверждает, что результат теста имеет тип expected

IsNotType(expected, result): метод подтверждает, что результат теста не представляет тип expected

IsNull(result): метод подтверждает, что результат теста имеет значение null

IsNotNull(result): метод подтверждает, что результат теста не равен null

InRange(result, low, high): метод подтверждает, что результат теста находится в диапазоне между low и high

NotInRange(result, low, high): метод подтверждает, что результат теста не принадлежит диапазону от low до high

Same(expected, actual): метод подтверждает, что ссылки expected и actual указывают на один и тот же объект в памяти

NotSame(expected, actual): метод подтверждает, что ссылки expected и actual указывают на разные объекты в памяти

Throws(exception, expression): метод подтверждает, что выражение expression генерирует исключение exception

*/