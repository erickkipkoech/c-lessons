
class EnrolledEventArgs:EventArgs{
    public short YearEnrolled{get;set;}
}


class EnrolledEvents{
//delegate event handler
    /*public delegate void EnrolledEventHandler(object sender,EnrolledEventArgs args);
    public event EnrolledEventHandler Enrolled;*/

    //generic event handler
public event EventHandler<EnrolledEventArgs> Enrolled;

    public void Enroll(){
        Enrolled(this,new EnrolledEventArgs{YearEnrolled=2023});
    }
}
