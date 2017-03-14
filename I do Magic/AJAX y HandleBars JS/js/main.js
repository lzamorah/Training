
$(function() {
	var space   = $("#user-template-js").html();
	var template = Handlebars.compile(space);

	json.users.sort(sort_by("ReTweets",json.users, parseInt));
	var users = json;//.users.sort(sort_by("ReTweets",json.users, parseInt));
	var html = template(users);
    console.log(html);

	$("#ranking-container").append(html);

	$(".function-button").on("click", function() {
	    var completeId = $(this).attr("id");
	    var id = completeId.split("-")[2];
	    if (completeId.slice(0, 8) === "btn-show") {
	    	$("#btn-show-" + id).css("display", "none");
	    	$("#btn-hide-" + id).css("display", "block");
	    	$("#profile-box" + id).css("display", "block");
	    } else {
	    	$("#btn-show-" + id).css("display", "block");
	    	$("#btn-hide-" + id).css("display", "none");
	    	$("#profile-box" + id).css("display", "none");
	    }
	});
});

Handlebars.registerHelper("position", function(index) {
  	return index;
});

var sort_by = function(field, reverse, primer){

   var key = primer ? 
       function(x) {return primer(x[field])} : 
       function(x) {return x[field]};

   reverse = !reverse ? 1 : -1;

   return function (a, b) {
       return a = key(a), b = key(b), reverse * ((a > b) - (b > a));
     } 
}