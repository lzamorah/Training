
$(function() {
	var space   = $("#user-template-js").html();
	var template = Handlebars.compile(space);

	var users = json;
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