$(document).ready(function(){


  //=================================== Nav Responsive ===================================//
    $('#menu').tinyNav({
       active: 'selected'
    });
  
    
  //=================================== Subtmit Form  =================================//

	$('#form').submit(function(event) {  
	  event.preventDefault();  
	  var url = $(this).attr('action');  
	  var datos = $(this).serialize();  
	  $.get(url, datos, function(resultado) {  
	    $('#result').html(resultado);  
	  });  
	}); 

  //=================================== Slide Border  =================================//
    $('#dg-container').gallery();

 //=================================== Nav Superfish ===============================//
    jQuery(document).ready(function() {
		jQuery('ul.sf-menu').superfish();
	});

         
});

$('.tool_tip').tooltip('hide')
