const copyButton = document.querySelector(".copy-button");
const copyText = document.querySelector(".copy-text");
copyButton.addEventListener("click",()=>{
    debugger;
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    document.execCommand("copy");
    copyButton.classList.toggle("success");
    copyButton.innerHTML = "Copied!";
    setTimeout(() => {
        copyButton.classList.toggle("success");
        copyButton.innerHTML="Copy";
    }, 2000);
});

  Sys.Application.add_load(function () {       
         
             function clickTabById(tabId) {
                var btn = document.getElementById(tabId);
                if (btn) {
                    btn.click();
                }
            }

        var time = new Date().getTime();
         $(document.body).bind("mousemove keypress", function(e) {
             time = new Date().getTime();
         });

         function refresh() {
             if(new Date().getTime() - time >= 300000) 
                 window.location.reload(true);
             else 
                 setTimeout(refresh, 10000);
         }

         setTimeout(refresh, 10000);



        
        var cartschemes = new Array();

        initialize();
        function initialize() {

            $('.btn_addtocart').click(function(){
                addtocart($(this));
              
            });

            $('.delete_cart').click(function(){
                deletecart($(this));
            
            });

            $('#fixed-contact').hide();

            if($('#cartdata>div').length > 0){
                //$('#shownewcart .cart-icon').css({'visibility':'visible','opacity':'1'});
                $('#items-count').text($('#cartdata>div').length);
                $('#cartdata>div').each(function(){
                    cartschemes.push($(this).attr('id'));
                });
                separateCartSchemes();
            }

            $('.iteminvamt').on('blur',function(){
                getCartTotal();
            
            });
            

            $('#btn-submit').click(function(e){
                getCartTotal();
                requestSubmit(e);
        
            });
            
        }

        getCartTotal();

        

        function showmoreschemes(ele,id,target)
        {
            $(id).removeClass('d-none');
            ele.addClass('d-none');
            $(target).find(".table-responsive>div").each(function(index){
                if(index < 10)
                {
                    $(this).removeClass('d-none');
                }
            });
        }


        function getCartTotal(){
            var total = 0;
            $('#cart_subtotal').text(total);
            $('.iteminvamt').each(function(){
                if($(this).val() == ""){
                    
                }else if(parseInt($(this).val()) < parseInt($(this).attr("d-min"))){
                    alert("Investment amount for this scheme cannot be less than " + $(this).attr("d-min"));
                    $(this).val(parseInt($(this).attr("d-min")));
                    total = total + parseInt($(this).val()); 
                }else{
                    total = total + parseInt($(this).val()); 
                }
                $('#cart_subtotal').text(total);
            });
            if(total > 0)
            {
                $('#btn-submit').removeAttr("disabled");
            }
            else
            {
                $('#btn-submit').prop("disabled","true");
            }
        }

        function requestSubmit(){
            var param = [];
            
            $('.iteminvamt').each(function(){
                var item = { schCode : $(this).attr("id").slice(8) ,amount : $(this).val(), type : $("#type"+$(this).attr("id").slice(8)).text() }
                param.push(item);
            });
            //console.log(param);
            $.ajax({
                url: "best-mf-schemes.aspx/requestsubmit",
                data: JSON.stringify({ param: param }),
                dataType: "json",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    if(data.d == true){
                        window.location.href = "../../MFunds/MFCartDetails.aspx";
                    }else if(data.d == false){
                        $("#modallogin").modal('show');
                    }
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    var err = eval("(" + XMLHttpRequest.responseText + ")");
                    alert(err.Message)
                },
                complete: function(){
                    
                }
            });
        }
   



   

    const amountSlider = document.getElementById("rangeAmount");
    const rateSlider = document.getElementById("rangeRate");
    const yearsSlider = document.getElementById("rangeYears");

    const amountVal = document.getElementById("valAmount");
    const rateVal = document.getElementById("valRate");
    const yearsVal = document.getElementById("valYears");
    const yearslabel = document.getElementById("years");

    const resultLabel = document.getElementById("totalamt");

    const radios = document.getElementsByName("investmentType");

    // Function to format numbers Indian style
  function formatIndianNumber(num) {
        // Convert to string
      let x = num.toString();
  
      // Extract last 3 digits
      let lastThree = x.substring(x.length - 3);
  
      // Extract digits before last 3
      let otherNumbers = x.substring(0, x.length - 3);
  
      if (otherNumbers !== '') {
        lastThree = ',' + lastThree;
      }
  
      // Add commas every 2 digits in the remaining part
      return otherNumbers.replace(/\B(?=(\d{2})+(?!\d))/g, ",") + lastThree;
  }

    // Function to set filled progress
    function updateSliderFill(slider) {
      const min = slider.min ? slider.min : 0;
      const max = slider.max ? slider.max : 100;
      const val = slider.value;

      const percent = ((val - min) * 100) / (max - min);
      slider.style.background = `linear-gradient(to right, #ec2723 ${percent}%, #dee2e6 ${percent}%)`;
    }

    // Calculation
    function calculate() {
      let type = document.querySelector('input[name="investmentType"]:checked').value;
     
      if(parseInt($("#valAmount").val()) > parseInt($("#valAmount").attr("max")))
      {
        $("#valAmount").val($("#valAmount").attr("max"));  
        alert('Please enter the amount below or equal to ₹'+ $("#valAmount").attr("max"));
      }
      else if(parseInt($("#valAmount").val()) < parseInt($("#valAmount").attr("min")))
      {
        $("#valAmount").val($("#valAmount").attr("min"));  
      }

      if(parseInt($("#valRate").val()) > parseInt($("#valRate").attr("max")))
      {
        $("#valRate").val($("#valRate").attr("max"));  
        alert('Please enter the rate below or equal to '+ $("#valRate").attr("max")+ '%');
      }
      else if(parseInt($("#valRate").val()) < parseInt($("#valRate").attr("min")))
      {
        $("#valRate").val($("#valRate").attr("min"));  
      }

      if(parseInt($("#valYears").val()) > parseInt($("#valYears").attr("max")))
      {
        $("#valYears").val($("#valYears").attr("max"));  
        alert('Please enter the period below or equal to '+ $("#valYears").attr("max")+' years');
      }
      else if(parseInt($("#valYears").val()) < parseInt($("#valYears").attr("min")))
      {
        $("#valYears").val($("#valYears").attr("min"));  
      }

      let amount = parseFloat(amountSlider.value);
      let annualRate = parseFloat(rateSlider.value);
      let years = parseInt(yearsSlider.value);

      let futureValue = 0;
      let months = 0;
      if (type === "SIP") {
        let monthlyRate = (annualRate / 100) / 12;
        months = years * 12;
        futureValue = amount * (Math.pow(1 + monthlyRate, months) - 1) / monthlyRate * (1 + monthlyRate);
        //document.getElementById("inv_amt").innerText = "₹ " + (months*amount);
        futureValue = futureValue.toFixed(0);
        //document.getElementById("profit").innerText = "₹ " + (futureValue - (months*amount));
        updateDonutChart(months*amount,futureValue - (months*amount));
        document.getElementById("amtlabel").innerText = "Monthly Investment";
      } else {
        let rate = annualRate / 100;
        futureValue = amount * Math.pow(1 + rate, years);
        //document.getElementById("inv_amt").innerText = "₹ " + (amount);
        futureValue = futureValue.toFixed(0);
        //document.getElementById("profit").innerText = "₹ " + (futureValue - (amount));
        updateDonutChart(amount,futureValue - (amount));
        document.getElementById("amtlabel").innerText = "Total Investment";
      }
      yearslabel.innerText = years;
      document.getElementById("totalamt").textContent = "₹ " + formatIndianNumber(futureValue);

      
    }

    // Sync slider and textbox
    function bindSliderAndBox(slider, box) {
      updateSliderFill(slider);

      slider.oninput = () => {
        box.value = slider.value;
        updateSliderFill(slider);
        calculate();
      };

      box.oninput = () => {
        let val = parseFloat(box.value);
        if (isNaN(val)) return;
        if (val < slider.min) val = slider.min;
        if (val > slider.max) val = slider.max;
        slider.value = val;
        updateSliderFill(slider);
        calculate();
      };
    }

    // Bind all
    bindSliderAndBox(amountSlider, amountVal);
    bindSliderAndBox(rateSlider, rateVal);
    bindSliderAndBox(yearsSlider, yearsVal);

    radios.forEach(r => r.onchange = calculate);

    // Initial
    calculate();

  });
