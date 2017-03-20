// 
//    All Rights Reserved
//    This software is proprietary information of
//    Intelligent Sense
//    Use is subject to license terms.
//    Filename: main.js
// 

$(function() {
	var template = Handlebars.templates['template.html'];

	// Order by ReTweets
	json.users.sort(sortBy("ReTweets",json.users, parseInt));
	var users = json;
	var html = template(users);

	$("#ranking-container").append(html);

	$(".function-button").on("click", function() {

	    var idProfile = $(this).attr("id");
	    var id = idProfile.split("-")[2];

	    if (idProfile.slice(0, 8) === "btn-show") {
	    	$("#btn-show-" + id).css("display", "none");
			$("#btn-hide-" + id).css("display", "block");
			$("#profile-box" + id).css("display", "block");
	    	// hideShowBox(id, "none","block","block");
	    } else {
	    	$("#btn-show-" + id).css("display", "block");
			$("#btn-hide-" + id).css("display", "none");
			$("#profile-box" + id).css("display", "none");
	    	// hideShowBox(id, "block","none","none");
	    }
	});
});

Handlebars.registerHelper("position", function(index) {
  	return index;
});

// function hideShowBox(id, btnShow, btnHide, profileBox){
// 	$("#btn-show-" + id).css("display", btnShow);
// 	$("#btn-hide-" + id).css("display", btnHide);
// 	$("#profile-box" + id).css("display", profileBox);
// }

var sortBy = function(field, reverse, primer){
   var key = primer ? 
       function(x) {return primer(x[field])} : 
       function(x) {return x[field]};

   reverse = !reverse ? 1 : -1;

   return function (a, b) {
       return a = key(a), b = key(b), reverse * ((a > b) - (b > a));
     } 
}