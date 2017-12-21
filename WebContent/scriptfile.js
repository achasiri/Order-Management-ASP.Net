function popthis() {
	alert("connected");
}

function CalculatePrice() {
	//alert("i am in");
	var smallPrice = 6;
	var mediumPrice = 9;
	var largePrice = 11;
//alert(smallPrice);
	var chocolatePrice = 1;
	var mintChocoChipPrice = 1.25;
	var strawberryPrice = 1.50;
	var vanillaPrice = 1.50;

	var saltedCrmlPrice = 0.5;
	var sfreeStwbryPrice = 0.7;

	var e = document.getElementById("flavorValue");
	var flavor_value = e.options[e.selectedIndex].text;
	
	var flavor_price;
	if (flavor_value == "Vanilla") {
		flavor_price = vanillaPrice;
	} else if (flavor_value == "Chocolate") {
		flavor_price = chocolatePrice;
	} else if (flavor_value == "Mint Chocolate Chip") {
		flavor_price = mintChocoChipPrice;
	} else {
		flavor_price = strawberryPrice;
	}

	var size_value;
	if (document.getElementById('small').checked) {
		size_value = document.getElementById('small').value;
	} else if (document.getElementById('medium').checked) {
		size_value = document.getElementById('medium').value;
	} else if (document.getElementById('large').checked) {
		size_value = document.getElementById('large').value;
	}
	
	var size_price;
	if (size_value == "Small") {
		size_price = smallPrice;
	} else if (size_value == "Meidum") {
		size_price = mediumPrice;
	} else {
		size_price = largePrice;
	}

	var quantity_value = document.getElementById("quantity").value;

	var extra_cost;
	if (document.getElementById("saltercaramel").checked == true
			&& document.getElementById("saltercaramel").checked == true) {
		extra_cost = saltedCrmlPrice * sfreeStwbryPrice;
	} else if (document.getElementById("saltercaramel").checked == true
			&& document.getElementById("saltercaramel").checked != true) {
		extra_cost = saltedCrmlPrice;
	} else if (document.getElementById("saltercaramel").checked != true
			&& document.getElementById("saltercaramel").checked == true) {
		extra_cost = sfreeStwbryPrice;
	} else {
		extra_cost = 0;
	}
var total_cost = quantity_value * (flavor_price + size_price + extra_cost);


var max=45;
var min=25;

var randTime= Math.floor(Math.random()*(max-min+1))+min;
//	var randTime=Math.round(Math.random()*100);
	
	document.getElementById("cost").innerHTML="The total cost is $"+total_cost;
	document.getElementById("time").innerHTML="your oder will be delivered in about "+randTime+" minutes";
	return false;
	//alert(total_cost);
	
}