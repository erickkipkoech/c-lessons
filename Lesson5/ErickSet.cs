//creating own generic type
class Erickset<T>
    {
    public List<T> _Inner=new List<T>();

    public void Add(T newItem)
    {
        var insertAt=_Inner.Count==0?0:new Random().Next(0,_Inner.Count+1);
        _Inner.Insert(insertAt,newItem);
    }

}
