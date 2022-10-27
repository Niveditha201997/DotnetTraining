/*
javascript datatype

1.var - global access
2.const- set the constant value
3.let-local access
DOM-DOCUMENT OBJECT MODEL
HTML 
*/

/*
for(var i=1;i<5;i++){    //for the function
    document.write(i);
}
document.write('Final i value :  '+i);

for(let i=1;i<5;i++){  // for the forloop,while loop...
    document.write(i);
}
document.write('Final i value :  '+i);
*/

// function ShowValue(){  //function definition
//     var liValues='';
// for(var i=1;i<5;i++){
//     //console.log(i);
//     liValues=liValues+'<li>'+i+'</li>';
// }
// //console.log('Final i value: '+i);
// document.getElementById('values').innerHTML=liValues;
// }

//ShowValue(); //calling

function ShowValue(){//function defenation

    var livalues='';
    
    for(var i=1;i<5;i++){
    
       // document.write(i);
    
       livalues=livalues+'<li>'+i+'</li>';
    
    }
    
    //console.log('final i value: '+i);
    
    document.getElementById('values').innerHTML=livalues;
    
    }
    
    
    
    ShowValue();