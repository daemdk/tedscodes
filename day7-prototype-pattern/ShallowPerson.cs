public class ShallowPerson : ICloneable
{
    public string? Name { get; set; }
    public Address Address { get; set; } = new();

    // 'Clone' 메소드를 통해 이 객체의 복사본을 생성합니다.
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
