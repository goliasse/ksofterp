 //单击btnSayHello时调用的JS函数
 function btnSayHello_onClick()
 {
     aspajaxdemo.SayHelloService.SayHello(HandleStateChange);
 }
 
 //回调函数
 function HandleStateChange(reusltText)
 {
    $get("result").innerHTML=reusltText;
}

function btnShowStudentInfo_onClick()
{
    var student = new aspajaxdemo.StudentInfo();
    student.Name="张无忌";
    student.Age="20";
    student.College="计算机学院";

    aspajaxdemo.StudentService.ShowStudentInfo(student, CallBackFunction);
}

function CallBackFunction(responseText)
{
    $get("result").innerHTML=responseText;
}