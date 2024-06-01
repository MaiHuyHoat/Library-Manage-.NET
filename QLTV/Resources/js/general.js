/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

document.addEventListener("DOMContentLoaded", function () {
  
    showErr();
    changeFormatMoney();
    loadLogin();
});
function loadLogin(){
        var userI = JSON.parse(window.sessionStorage.getItem("user"));
        var userDiv= document.querySelector("#user")
     console.log(userI)
   userDiv.innerHTML=userI.name;
}
function changeFormatMoney(){
    var moneyDiv= document.querySelectorAll(".format-money");
    for(var i=0;i<moneyDiv.length;i++){
        var element= moneyDiv[i];
        var money= parseFloat(element.innerText) ;

        element.innerHTML=formatMoney(money);
    }
}
function showErr(){
         var errStr= document.getElementById("errorString")
                              var str=errStr.value;
                              if(typeof str==="string" && str.length!==0)
                              alert(str) 
}

function update( button){
    var url= button.getAttribute('href')
    var id= button .getAttribute("value");
    window.location.href=url+`?id=${id}`;
}
function remove( button){
    var url= button.getAttribute('href')
    var id= button .getAttribute("value");
     var choose  =window.confirm("Không thể xoá yêu cầu mượn vì nó liên quan đến bảng khác. Thay vào đó nó sẽ vào trạng thái ẩn.\n\n\
        Bạn có chắc muốn xoá yêu cầu mượn có id: "+id)
    if(choose){
         window.location.href=url+`?id=${id}`;   
    }

}

function formatMoney(amount) {
    amount = Math.round(amount);

    // Định dạng số thành chuỗi và bỏ số thập phân
    return amount.toString().replace(/\d(?=(\d{3})+$)/g, '$&,');
}
function calculateDaysBetweenDates(dateString1, dateString2) {
    var date1 = new Date(dateString1);
    var date2 = new Date(dateString2);
    
    var timeDifference = date2.getTime() - date1.getTime();
    var dayDifference = Math.floor(timeDifference / (1000 * 3600 * 24));
    
    return dayDifference; // Đảm bảo kết quả là số nguyên dương
}



