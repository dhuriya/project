
var ISSUES={
  ipo:[
    {id:'i1',co:'Muthoot Fincorp Limited',abbr:'MF',size:'Rs. 600 crores',rating:'"Crisil AA-Positive" by Crisil and BWR AA/Stable" by Brickwork',opens:'24/04/2026',closes:'08/05/2026'},
    {id:'i2',co:'Muthoot Fincorp Limited',abbr:'MF',size:'Rs. 600 crores',rating:'"Crisil AA-Positive" by Crisil and BWR AA/Stable" by Brickwork',opens:'24/04/2026',closes:'08/05/2026'},
    {id:'i3',co:'Kotak Mahindra IPO',abbr:'KM',size:'Rs. 980 crores',rating:'"AAA/Stable" by CRISIL',opens:'01/05/2026',closes:'10/05/2026'}
  ],
  sme:[
    {id:'s1',co:'Arjun Agri Products Ltd',abbr:'AA',size:'Rs. 45 crores',rating:'Not Rated',opens:'28/04/2026',closes:'30/04/2026'},
    {id:'s2',co:'GreenTech Solutions Ltd',abbr:'GT',size:'Rs. 62 crores',rating:'Not Rated',opens:'05/05/2026',closes:'07/05/2026'}
  ],
  ncd:[
    {id:'n1',co:'Muthoot Finance NCD',abbr:'MF',size:'Rs. 1200 crores',rating:'AA+/Stable by CRISIL',opens:'01/05/2026',closes:'15/05/2026'},
    {id:'n2',co:'Tata Capital NCD',abbr:'TC',size:'Rs. 800 crores',rating:'AAA/Stable by ICRA',opens:'10/05/2026',closes:'25/05/2026'}
  ]
};

var CLIENTS=[
  {name:'Rahul Singh',code:'RS78451',pan:'QRSTU6789V',mob:'+91 9711 223344'},
  {name:'Rahul Gupta',code:'RS22345',pan:'VWXYZ3456W',mob:'+91 9654 112233'},
  {name:'Priya Mehta',code:'PM63210',pan:'ABCDE7890X',mob:'+91 9445 998877'},
  {name:'Priyanka Sharma',code:'PS10023',pan:'FGHIJ1234Y',mob:'+91 9334 776655'},
  {name:'Amit Verma',code:'AV55671',pan:'KLMNO5678Z',mob:'+91 9223 445566'},
  {name:'Sunita Yadav',code:'SY44321',pan:'PQRST9012A',mob:'+91 9812 334455'},
  {name:'Deepak Kumar',code:'DK99123',pan:'UVWXY3456B',mob:'+91 9567 778899'},
  {name:'Neha Joshi',code:'NJ77654',pan:'ZABCD7890C',mob:'+91 9321 556677'},
  {name:'Vikram Patel',code:'VP11230',pan:'EFGHI1234D',mob:'+91 9876 223344'},
  {name:'Kavita Singh',code:'KS55432',pan:'JKLMN5678E',mob:'+91 9654 998800'},
];

var added=[];
var selType=null;

function ini(n){return n.split(' ').map(function(w){return w[0];}).join('').slice(0,2).toUpperCase();}
function fuzz(s,q){s=s.toLowerCase();q=q.toLowerCase();if(s.indexOf(q)!=-1)return 2;var si=0;for(var i=0;i<q.length;i++){var p=s.indexOf(q[i],si);if(p==-1)return 0;si=p+1;}return 1;}
function hl(t,q){if(!q)return t;var i=t.toLowerCase().indexOf(q.toLowerCase());if(i==-1)return t;return t.slice(0,i)+'<span class="hl">'+t.slice(i,i+q.length)+'</span>'+t.slice(i+q.length);}
function isAdded(code){return added.some(function(c){return c.code===code;});}

function renderIssues(type){
  var list=ISSUES[type]||[];
  return list.map(function(iss){
    return '<div class="icard" data-id="'+iss.id+'">'
     +'<div class="crow"><div class="clogo">'+iss.abbr+'</div>'
     +'<span class="cco">'+iss.co+'</span>'
     +'<span class="chip chip-'+type+'">'+type.toUpperCase()+'</span></div>'
     +'<div class="cmeta">'
     +'<div class="crow2"><span class="clbl">Issue Size</span><span class="cval gv">'+iss.size+'</span></div>'
     +'<div class="crow2"><span class="clbl">Opens</span><span class="cval">'+iss.opens+'</span></div>'
     +'<div class="crow2"><span class="clbl">Closes</span><span class="cval">'+iss.closes+'</span></div>'
     +'<div class="crating">★ '+iss.rating+'</div>'
     +'</div></div>';
  }).join('');
}

function renderRow(c){
  return '<div class="citem" id="cr-'+c.code+'">'
   +'<div class="cav">'+ini(c.name)+'</div>'
   +'<div class="cinfo"><div class="cname">'+c.name+'<span class="dot"></span></div>'
   +'<div class="cmetas">'
   +'<div><div class="cml">Client Code</div><div class="cmv">'+c.code+'</div></div>'
   +'<div><div class="cml">PAN</div><div class="cmv">'+c.pan+'</div></div>'
   +'<div><div class="cml">Mobile</div><div class="cmv">'+c.mob+'</div></div>'
   +'<div><div class="cml">Status</div><div class="cmv" style="color:#16a34a">✓ Online</div></div>'
   +'</div></div>'
   +'<button type="button" class="apbtn" data-code="' + c.code + '">✓ Apply Client</button>'
   + '<button type="button" class="rmbtn" data-code="' + c.code + '" title="Remove"><i class="fa-solid fa-trash remove12"></i></button>'
   +'</div>';
}

function refreshList(){
  var scr=document.getElementById('cscroll');
  var lcnt=document.getElementById('lcnt');
  var empty=document.getElementById('emptyMsg');
  lcnt.textContent=added.length;
  if(!added.length){
      scr.innerHTML = '<div class="empty-cl" id="emptyMsg">No client has been added yet — please search from above ⬆</div>';
    return;
  }
  if(empty)empty.remove();
  var existing=scr.querySelectorAll('.citem');
  var existCodes=Array.from(existing).map(function(el){return el.id.replace('cr-','');});
  added.forEach(function(c){
    if(existCodes.indexOf(c.code)===-1){
      scr.insertAdjacentHTML('beforeend',renderRow(c));
    }
  });
}

function addClient(code){
  if(isAdded(code))return;
  var c=CLIENTS.find(function(x){return x.code===code;});
  if(!c)return;
  added.push(c);
  var empty=document.getElementById('emptyMsg');
  if(empty)empty.remove();
  document.getElementById('cscroll').insertAdjacentHTML('beforeend',renderRow(c));
  document.getElementById('lcnt').textContent=added.length;
  showDD(document.getElementById('cinp').value);
  setTimeout(function(){
    var row=document.getElementById('cr-'+code);
    if(row){row.style.background='rgba(200,168,75,.07)';setTimeout(function(){if(row)row.style.background='';},700);}
  },40);
}

function removeClient(code){
  added=added.filter(function(c){return c.code!==code;});
  var row=document.getElementById('cr-'+code);
  if(row){
    row.style.opacity='0';row.style.transform='translateX(12px)';row.style.transition='all .25s';
    setTimeout(function(){
      if(row.parentNode)row.parentNode.removeChild(row);
      document.getElementById('lcnt').textContent=added.length;
      if(!added.length){
          document.getElementById('cscroll').innerHTML = '<div class="empty-cl" id="emptyMsg">No client has been added yet — please search from above ⬆</div>';
      }
    },260);
  }
  showDD(document.getElementById('cinp').value);
}

function showDD(q){
  var dd=document.getElementById('cdd');
  if(!q||!q.trim()){dd.style.display='none';return;}
  var m=CLIENTS.map(function(c){return Object.assign({},c,{score:fuzz(c.name+' '+c.code,q)});})
    .filter(function(c){return c.score>0;})
    .sort(function(a,b){return b.score-a.score;}).slice(0,7);
  if (!m.length) { dd.innerHTML = '<div class="dempty">No client found</div>'; dd.style.display = 'block'; return; }
  dd.innerHTML=m.map(function(c){
    var btn=isAdded(c.code)
      ?'<span class="dadded">✓ Added</span>'
      :'<button class="dadd" data-code="'+c.code+'">+ ADD</button>';
    return '<div class="ddi">'
     +'<div class="dav">'+ini(c.name)+'</div>'
     +'<div style="flex:1;min-width:0"><div class="dm">'+hl(c.name,q)+'</div><div class="ds">'+c.code+' · '+c.mob+'</div></div>'
     +btn+'</div>';
  }).join('');
  dd.style.display='block';
}

function selectType(type){
  selType=type;
  document.querySelectorAll('.type-btn').forEach(function(b){b.classList.toggle('active',b.dataset.t===type);});
  var names={ipo:'IPO — Initial Public Offering',sme:'SME — Small & Medium Enterprise',ncd:'NCD — Non-Convertible Debentures'};
  document.getElementById('badgename').textContent=names[type];
  document.getElementById('selbadge').style.display='flex';
  document.getElementById('strip').innerHTML=renderIssues(type);
  document.getElementById('stripwrap').style.display='block';
}

document.querySelectorAll('.type-btn').forEach(function(b){
  b.addEventListener('click',function(){selectType(this.dataset.t);});
});

document.getElementById('cinp').addEventListener('input',function(){showDD(this.value.trim());});
document.getElementById('cinp').addEventListener('blur',function(){setTimeout(function(){document.getElementById('cdd').style.display='none';},200);});
document.getElementById('sbtn').addEventListener('click',function(){
  var q=document.getElementById('cinp').value.trim();
  showDD(q||' ');
  document.getElementById('cdd').style.display='block';
});

document.addEventListener('mousedown',function(e){
  var t=e.target;
  if(t.classList.contains('dadd')){e.preventDefault();addClient(t.dataset.code);}
  var rm=t.closest?t.closest('.rmbtn'):null;
  if(rm){removeClient(rm.dataset.code);}
  var ap=t.closest?t.closest('.apbtn'):null;
  if(ap){
    if(!selType){alert('Pehle IPO / SME / NCD select karein!');return;}
    var c=added.find(function(x){return x.code===ap.dataset.code;});
    if(c)alert('Applying '+selType.toUpperCase()+' for:\n'+c.name+' ('+c.code+')');
  }
  var ic=t.closest?t.closest('.icard'):null;
  if(ic&&!t.closest('.dadd')&&!t.closest('.rmbtn')&&!t.closest('.apbtn')){
    document.querySelectorAll('.icard').forEach(function(c){c.classList.remove('sel');});
    ic.classList.add('sel');
  }
});

document.getElementById('anbtn').addEventListener('click',function(){
    if (!selType) { alert('Please select IPO / SME / NCD first!'); return; }
    if (!added.length) { alert('No client has been added.!'); return; }
  var btn=this;
  btn.innerHTML='⏳ Processing...';btn.disabled=true;
  setTimeout(function(){
    btn.innerHTML='✅ Applied Successfully!';
    btn.style.background='linear-gradient(135deg,#22c55e,#16a34a)';
    btn.style.color='#fff';btn.disabled=false;
    setTimeout(function(){
      btn.innerHTML='⚡ Apply Now →';
      btn.style.background='';btn.style.color='';
    },3000);
  },1800);
});
