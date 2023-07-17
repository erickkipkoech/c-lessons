public enum LightSwitch{
    Off,
    FiftyPercent,
    Bright,
    Nuclear,
    On,
    //you can assign it toa a value
    MilitaryLeave=20
}


//using enum with a class
class Enrollment{
public enum EnrolledState{
    NotEnrolled = 0,
    Enrolled = 5,
    OnMentorship = 10,
    Internship = 11,
    MilitaryLeave = 20    
}

public EnrolledState Enroll(){
    return EnrolledState.MilitaryLeave;
}
}
//enum flags
[Flags]
public enum FileAccess{
    Read=1,
    Write=2,
    Execute=4,
    Delete=8
}

[Flags]
public enum DaysOfWeek{
        None      = 0b_0000_0000,  // 0
    Monday    = 0b_0000_0001,  // 1
    Tuesday   = 0b_0000_0010,  // 2
    Wednesday = 0b_0000_0100,  // 4
    Thursday  = 0b_0000_1000,  // 8
    Friday    = 0b_0001_0000,  // 16
    Saturday  = 0b_0010_0000,  // 32
    Sunday    = 0b_0100_0000,  // 64
    Weekend   = Saturday | Sunday

}
