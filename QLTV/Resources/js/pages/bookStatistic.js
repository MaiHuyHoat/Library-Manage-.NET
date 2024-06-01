/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

 function requestExportExcel(){
    fetch("/QuanLyThuVien/ExportExcel",{
       "method":"get",
        "content/type":"application/json"
    }).then(res=>{
        if(res.ok){
            alert("Xuất file Excel thành công. \nFile lưu ở mục dowload của máy tính")
        }
    }).catch(err=>console.log(err))
}


