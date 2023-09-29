// this junk just for PoC

$('.sidebar a').click(function () {
	$('.sidebar li').removeClass('active');
	$(this).parent().addClass('active');
	if ($(this).data('sidenav') == true) {
		$('.subnav').addClass('active');
	} else {
		$('.subnav').removeClass('active')
	}
});

$('.subnav a').click(function () {
	$('.subnav li').removeClass('active');
	$(this).parent().addClass('active');
});