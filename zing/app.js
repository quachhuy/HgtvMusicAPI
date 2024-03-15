const music = new Audio('music/song4.mp3');
// music.play();

const songs = [
    {
        id:1 ,
        songName:`Rồi tới luôn <br>
        <div class="subtitle">Nal</div> `,
        poster: "img/song/song1.jpg"
    },
    {
        id:2 ,
        songName:`Yêu là cưới <br>
        <div class="subtitle">PHÁT HỒ X2X</div> `,
        poster: "img/song/song2.jpg"
    },
    {
        id:3 ,
        songName:`Độ Tộc 2<br>
        <div class="subtitle">Masew X Độ Mixi X Phúc Du X Pháo</div> `,
        poster: "img/song/song3.jpg"
    },
    {
        id:4 ,
        songName:`Chúng Ta Của Hiện Tại<br>
        <div class="subtitle">Sơn Tùng M-TP</div> `,
        poster: "img/song/song4.jpg"
    },
    {
        id:5 ,
        songName:`Em Không Hiểu<br>
        <div class="subtitle">Changg x Minh Huy</div> `,
        poster: "img/song/song5.jpg"
    },
    {
        id:6 ,
        songName:`Đã Lỡ Yêu Em Nhiều<br>
        <div class="subtitle">JustaTee</div> `,
        poster: "img/song/song6.jpg"
    },
    {
        id:7 ,
        songName:`Cưới Đi<br>
        <div class="subtitle">2T X ChangC</div> `,
        poster: "img/song/song7.jpg"
    },
    {
        id:8 ,
        songName:`Ái Nộ<br>
        <div class="subtitle">Masew X Khoi Vu</div> `,
        poster: "img/song/song8.jpg"
    },
    {
        id:9 ,
        songName:`Thằng Điên<br>
        <div class="subtitle">JustaTee X Phương Ly</div> `,
        poster: "img/song/song9.jpg"
    },
    {
        id:10 ,
        songName:`Yêu Đơn Phương<br>
        <div class="subtitle">OnlyC X Karik</div> `,
        poster: "img/song/song10.jpg"
    },
    {
        id:11 ,
        songName:`Trời Giấu Trời Mang Đi<br>
        <div class="subtitle">AMEE X VIRUSS</div> `,
        poster: "img/song/song11.jpg"
    },
    {
        id:12 ,
        songName:`Ex's Hate Me<br>
        <div class="subtitle">B Ray X Masew X AMEE</div> `,
        poster: "img/song/song12.jpg"
    },
    {
        id:13 ,
        songName:`The PlayAh<br>
        <div class="subtitle">Soobin X SlimV</div> `,
        poster: "img/song/song13.jpg"
    },
    {
        id:14 ,
        songName:`Muộn Rồi Mà Sao Còn<br>
        <div class="subtitle">Sơn Tùng MTP</div> `,
        poster: "img/song/song14.jpg"
    },
    {
        id:15 ,
        songName:`Cưới Thôi<br>
        <div class="subtitle">Masew X B Ray X TAP</div> `,
        poster: "img/song/song15.jpg"
    },
    {
        id:16 ,
        songName:`Mượn Rượu Tỏ Tình<br>
        <div class="subtitle">Big Daddy X Emily</div> `,
        poster: "img/song/song16.jpg"
    },
    {
        id:17 ,
        songName:`Yêu Một Người Có Lẽ<br>
        <div class="subtitle">Lou Hoàng X Miu Lê</div> `,
        poster: "img/song/song17.jpg"
    },
    {
        id:18 ,
        songName:`Anh Không Đòi Quà<br>
        <div class="subtitle">OnlyC X Karik</div> `,
        poster: "img/song/song18.jpg"
    },
    {
        id:19 ,
        songName:`Đi Đu Đưa Đi<br>
        <div class="subtitle">Bích Phương</div> `,
        poster: "img/song/song19.jpg"
    },
    {
        id:20 ,
        songName:`BlackJack<br>
        <div class="subtitle">Soobin X Binz</div> `,
        poster: "img/song/song20.jpg"
    },

] 

Array.from(document.getElementsByClassName('songItem')).forEach((element, i) => {
    element.getElementsByTagName('img')[0].src = songs[i].poster;
    element.getElementsByTagName('h5')[0].innerHTML = songs[i].songName;
})

let masterPlay = document.getElementById('masterPlay');
let wave = document.getElementsByClassName('wave')[0];

masterPlay.addEventListener('click',() =>{
    if(music.paused || music.currentTime <= 0){
        music.play();
        masterPlay.classList.remove('bi-play-fill');
        masterPlay.classList.add('bi-pause-fill');
        wave.classList.add('active2');
    }else{
        music.pause();
        masterPlay.classList.add('bi-play-fill');
        masterPlay.classList.remove('bi-pause-fill');
        wave.classList.remove('active2');
    }
})

const makeAllPlay = () =>{
    Array.from(document.getElementsByClassName('playlistPlay')).forEach((element) => {
            element.classList.add('bi-play-circle-fill');
            element.classList.remove('bi-pause-circle-fill');
        })
}

const makeAllBackground = () =>{
    Array.from(document.getElementsByClassName('songItem')).forEach((element) => {
            element.style.background = "rgb(105, 105, 170, 0)";
        })
}
let index = 0;
let poster_master_play = document.getElementById('poster_master_play');
let title = document.getElementById('title');

Array.from(document.getElementsByClassName('playlistPlay')).forEach((element) => {
    element.addEventListener('click',(e) =>{
        index = e.target.id;
        makeAllPlay();
        e.target.classList.remove('bi-play-circle-fill');
        e.target.classList.add('bi-pause-circle-fill');
        music.src = `music/song${index}.mp3`;
        poster_master_play.src = `img/song/song${index}.jpg`;
        music.play();
        let song_title = songs.filter((ele) =>{
            return ele.id == index;
        })
        
        song_title.forEach(ele =>{
            let {songName} = ele;
            title.innerHTML = songName;
        })
        masterPlay.classList.remove('bi-play-fill');
        masterPlay.classList.add('bi-pause-fill');
        wave.classList.add('active2');
        music.addEventListener('ended',() => {
            masterPlay.classList.add('bi-play-fill');
            masterPlay.classList.remove('bi-pause-fill');
            wave.classList.remove('active2');
        })
        makeAllBackground();
        Array.from(document.getElementsByClassName('songItem'))[`${index-1}`].style.background = "rgb(105, 105, 170, .1)";

    })
})


let currentStart = document.getElementById('currentStart');
let currentEnd = document.getElementById('currentEnd');
let seek = document.getElementById('seek');
let bar2 = document.getElementById('bar2');
let dot = document.getElementsByClassName('dot')[0];

music.addEventListener('timeupdate',() =>{
    let music_cur = music.currentTime;
    let music_dur = music.duration;

    let min = Math.floor(music_dur/60);
    let sec = Math.floor(music_dur%60);

    if(sec<10){
        sec = `0${sec}`
    }
    currentEnd.innerText = `${min}:${sec}`;

    let min1 = Math.floor(music_cur/60);
    let sec1 = Math.floor(music_cur%60);

    if(sec1<10){
        sec1 = `0${sec1}`
    }
    currentStart.innerText = `${min1}:${sec1}`;

    let progressbar = parseInt((music.currentTime/music.duration)*100);
    seek.value = progressbar;
    let seekbar = seek.value;
    bar2.style.width = `${seekbar}%`;
    dot.style.left = `${seekbar}%`;
})

seek.addEventListener('change', () => {
    music.currentTime = seek.value * music.duration/100;
})

music.addEventListener('ended',() =>{
    masterPlay.classList.add('bi-play-fill');
    masterPlay.classList.remove('bi-pause-fill');
    wave.classList.remove('active2');
})

let vol_icon = document.getElementById('vol_icon');
let vol = document.getElementById('vol');
let vol_dot = document.getElementById('vol_dot');
let vol_bar = document.getElementsByClassName('vol_bar')[0];

vol.addEventListener('change',() =>{
    if(vol.value == 0){
        vol_icon.classList.remove('bi-volume-down-fill')
        vol_icon.classList.add('bi-volume-mute-fill')
        vol_icon.classList.remove('bi-volume-up-fill')
    }
    if(vol.value > 0){
        vol_icon.classList.add('bi-volume-down-fill')
        vol_icon.classList.remove('bi-volume-mute-fill')
        vol_icon.classList.remove('bi-volume-up-fill')
    }
    if(vol.value > 50){
        vol_icon.classList.remove('bi-volume-down-fill')
        vol_icon.classList.remove('bi-volume-mute-fill')
        vol_icon.classList.add('bi-volume-up-fill')
    }

    let vol_a = vol.value;
    vol_bar.style.width = `${vol_a}%`;
    vol_dot.style.left = `${vol_a}%`;
    music.volume = vol_a/100;
})

let back = document.getElementById('back');
let next = document.getElementById('next');

back.addEventListener('click',() =>{
    index -= 1;
    if(index<1){
        index = Array.from(document.getElementsByClassName('songItem')).length;
    }
    music.src = `music/song${index}.mp3`;
        poster_master_play.src = `img/song/song${index}.jpg`;
        music.play();
        let song_title = songs.filter((ele) =>{
            return ele.id == index;
        })
        
        song_title.forEach(ele =>{
            let {songName} = ele;
            title.innerHTML = songName;
        })
        makeAllPlay();
        document.getElementById(`${index}`).classList.remove('bi-play-fill');
        document.getElementById(`${index}`).classList.add('bi-pause-fill');
        makeAllBackground();
        Array.from(document.getElementsByClassName('songItem'))[`${index-1}`].style.background = "rgb(105, 105, 170, .1)";
})

next.addEventListener('click',() =>{
    index -= 0;
    index += 1;
    if(index = Array.from(document.getElementsByClassName('songItem')).length){
        index = 1;
    }
    music.src = `music/song${index}.mp3`;
        poster_master_play.src = `img/song/song${index}.jpg`;
        music.play();
        let song_title = songs.filter((ele) =>{
            return ele.id == index;
        })
        
        song_title.forEach(ele =>{
            let {songName} = ele;
            title.innerHTML = songName;
        })
        makeAllPlay();
        document.getElementById(`${index}`).classList.remove('bi-play-fill');
        document.getElementById(`${index}`).classList.add('bi-pause-fill');
        makeAllBackground();
        Array.from(document.getElementsByClassName('songItem'))[`${index-1}`].style.background = "rgb(105, 105, 170, .1)";
})

let left_scroll = document.getElementById('left_scroll');
let right_scroll = document.getElementById('right_scroll');
let pop_song = document.getElementsByClassName('pop_song')[0];

left_scroll.addEventListener('click',() =>{
    pop_song.scrollLeft -= 330;
})

right_scroll.addEventListener('click',() =>{
    pop_song.scrollLeft += 330;
})

let left_scrolls = document.getElementById('left_scrolls');
let right_scrolls = document.getElementById('right_scrolls');
let item = document.getElementsByClassName('item')[0];

left_scrolls.addEventListener('click',() =>{
    item.scrollLeft -= 330;
})

right_scrolls.addEventListener('click',() =>{
    item.scrollLeft += 330;
})