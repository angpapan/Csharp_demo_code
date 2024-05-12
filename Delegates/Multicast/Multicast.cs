namespace Delegates.Multicast;

delegate void Calculation(int oper);

internal class Multicast
{
    int _num;
    public int Num => _num;
    public Calculation Calc { get; set; }
    public Multicast(int num) { _num = num; }
    public void Add(int oper) => _num += oper;
    public void Multiply(int oper) => _num *= oper;


}
