/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
document.addEventListener("DOMContentLoaded",()=>{
    TienQuaHan();
    
})
console.log("nhan file js")
function formatMoney(amount) {
    return amount.toFixed(2).replace(/\d(?=(\d{3})+\.)/g, '$&,');
}

function calculateDaysBetweenDates(dateString1, dateString2) {
    var date1 = new Date(dateString1);
    var date2 = new Date(dateString2);
    
    var timeDifference = date2.getTime() - date1.getTime();
    var dayDifference = Math.floor(timeDifference / (1000 * 3600 * 24));
    
    return dayDifference; // Đảm bảo kết quả là số nguyên dương
}
function TienQuaHan(){
    var return_date=document.querySelector("#return_date");
    var due_date= document.querySelector("#due_date");
   var date_out= calculateDaysBetweenDates(due_date.value,return_date.value);
          var bookPrice= parseFloat(document.getElementById("book-price").value);
           var spanTienQuaHan= document.querySelector("#tienQuaHan");
        var divTien= document.getElementById("tienBoiThuong").parentElement.parentElement;
   if(date_out>0){

    
       spanTienQuaHan.innerHTML=formatMoney(date_out*bookPrice*0.1);
       spanTienQuaHan.parentElement.parentElement.classList.remove("d-none")
        if(!divTien.classList.contains("d-none"))divTien.classList.add("d-none")
   }else{
       var spanTienQuaHan= document.querySelector("#tienQuaHan");

       spanTienQuaHan.parentElement.parentElement.classList.add("d-none")
        ThayDoiTrangThai()
   }
}

function ThayDoiTrangThai(select){
    var bookPrice= parseFloat(document.getElementById("book-price").value);
        var divTienQuaHan= document.querySelector("#tienQuaHan").parentElement.parentElement;
        var spanTien= document.getElementById("tienBoiThuong");
    if(select.value==="3" ){
        
        spanTien.innerHTML=formatMoney(bookPrice);

         var div= spanTien.parentElement.parentElement;
         div.classList.remove("d-none")
         if(!divTienQuaHan.classList.contains("d-none"))divTienQuaHan.classList.add("d-none")
    }else{
               var spanTien= document.getElementById("tienBoiThuong");

         var div= spanTien.parentElement.parentElement;
         div.classList.add("d-none")
         TienQuaHan()
    }

}

