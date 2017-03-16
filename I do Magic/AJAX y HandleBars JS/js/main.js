// 
//    All Rights Reserved
//    This software is proprietary information of
//    Intelligent Sense
//    Use is subject to license terms.
//    Filename: main.js
// 

$(function() {
	var space   = $("#user-template-js").html();
	var template = Handlebars.compile(space);

	// Order by ReTweets
	json.users.sort(sort_by("ReTweets",json.users, parseInt));
	var users = json;
	var html = template(users);
    console.log(html);

	$("#ranking-container").append(html);

	$(".function-button").on("click", function() {

	    var idProfile = $(this).attr("id");
	    var id = idProfile.split("-")[2];

	    if (idProfile.slice(0, 8) === "btn-show") {
	    	hide_show_box(id, "none","block","block");
	    } else {
	    	hide_show_box(id, "block","none","none");
	    }
	});
});

Handlebars.registerHelper("position", function(index) {
  	return index;
});

function hide_show_box(id, btnShow, btnHide, profileBox){
	$("#btn-show-" + id).css("display", btnShow);
	$("#btn-hide-" + id).css("display", btnHide);
	$("#profile-box" + id).css("display", profileBox);
}

var sort_by = function(field, reverse, primer){

   var key = primer ? 
       function(x) {return primer(x[field])} : 
       function(x) {return x[field]};

   reverse = !reverse ? 1 : -1;

   return function (a, b) {
       return a = key(a), b = key(b), reverse * ((a > b) - (b > a));
     } 
}