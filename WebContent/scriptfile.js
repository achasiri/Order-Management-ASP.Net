var flavorSelection;
var sizeSelection = false;
var quantitySelection;
var toppingSelection = false;


function price(){
	var x = 1.00;
	var flavour = document.getElementById("flavours").value;
	if(flavour == "chocolate"){
		 x=1.00;
		// alert('hello');
	}else if(flavour == "mint"){
		 x=1.25;
	}else if(flavour == "strawberry"){
		 x=1.50;
	}else if(flavour == "vanilla"){
		 x=1.50;
	}
	
	//alert(x);
	
	if(document.getElementById("size1").checked){
		var radio = document.getElementById("size1").value;
		 document.getElementById("size1").checked = false;
	}else if(document.getElementById("size2").checked){
		var radio = document.getElementById("size2").value;
		 document.getElementById("size2").checked = false;
	}else if(document.getElementById("size3").checked){
		var radio = document.getElementById("size3").value;
		 document.getElementById("size3").checked = false;
	}
		
	var y = 0.00;
	if(radio === "small"){
		 y=6.00;
	}else if(radio === "medium"){
		 y=9.00;
	}else if(radio === "large"){
		 y=11.00;
	}
	//alert(y);
	
	var quantity = document.getElementById("quantity").value;
	//alert(quantity);
	
	var checks = document.getElementsByName('topping');
	var str="";
	var val=1.00;
	
	for(i = 0; i < 2;i++){
		if(checks[i].checked){
			str += checks[i].value + " ";
		}
	}
	if(str === "salted caramel "){
		//alert("inside1");
		val = 1.70;
	}else if(str === "sugar free strawbeery "){
		//alert("inside2");
		val = 1.50;
	}else if(str === "salted caramel sugar free strawbeery "){
		//alert("inside");
		val=1.10;
	}
	//alert(val);
	
	var msg = (quantity * (y + x + val));
	
	document.getElementById("message").innerHTML="The total cost is $"+msg;
	document.getElementById("time").innerHTML="Your order will be delivered in about "+Math.floor((Math.random()*20) + 25);
}

function myFlavorsSelected() {
	flavorSelection = document.getElementById("flavours").value;
	disableOrderButton();
}

function radioSelection() {
	var sizeValArray = document.getElementsByName('sizeVal');
	//sizeSelection = arrayUtil(sizeValArray);
	sizeValArray.forEach(function(eachElement) {
		if (eachElement.checked) {
			sizeSelection = true;
		}
	});
	disableOrderButton();
}

 function toppingsSelection() {
	var toppingsArr = document.getElementsByName('topping');
	//toppingSelection = arrayUtil(toppingsArr);
	toppingsArr.forEach(function(eachElement) {
		if (eachElement.checked) {
			toppingSelection = true;
		}
	});
	disableOrderButton();
}
 

function inputSelection() {
	var quantity = document.getElementById("quantity").value;
	if (quantity < 1 || quantity > 10) {
        document.getElementById("errorMessage").innerHTML = "Input not valid";
        quantitySelection = undefined;
    } else {
    	quantitySelection = quantity;
    }
    disableOrderButton();
}

function disableOrderButton() {
	if (!flavorSelection || !sizeSelection || !quantitySelection ) {
		document.getElementById("orderButton").disabled = true;
	} else {
		document.getElementById("orderButton").disabled = false;
	}
}
function changeColor(x) {
    x.style.color = "red";
}
