import React, { Component } from 'react';
import IdolPersonalInfo from '../components/IdolPersonalInfo';
import IdolLifeStory from '../components/IdolLifeStory';
import IdolImages from '../components/IdolImages';
import FloatingButton from '../components/common/FloatingButton';
import Footer from '../components/common/Footer';
import IdolVideos from '../components/IdolVideos';

export default class Home extends Component {
  render() {
    return  (
      <div id="colorlib-page">
    <a href="#" className="js-colorlib-nav-toggle colorlib-nav-toggle"><i></i></a>
    <aside id="colorlib-aside" role="complementary" className="js-fullheight text-center">
        {/* <a href="#" className="">
            <i className="icon-home btn-home icon-hover"></i>
        </a> */}
        <div id="colorlib-logo" className="mb-3">
            <div className="hero-wrap">
                <div className="text">
                    <a className="img idol-avatar-img" style={{
                      backgroundImage:
                      "url(https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/b0/b083676cf39cedcfe350ed01c0b2f5785d1282c2_full.jpg)"
                    }}></a>
                    <div className="d-flex justify-content-center">
                        <a href="#" className="idol-checkmark-container"><i className="icon-check idol-checkmark"></i></a>
                        <strong className="idol-name idol-name-shadow">Mia Khalifa</strong>
                    </div>
                </div>
            </div>
        </div>
        <nav id="colorlib-main-menu" role="navigation">
            <ul>
                <li className="colorlib-active"><a href="">Giới thiệu</a></li>
                <li><a href="">Tiếu sử</a></li>
                <li><a href="">Hình ảnh</a></li>
                <li><a href="">Video</a></li>
                <li><a href="">Diễn đàn</a></li>
                <li><a href="">Voting</a></li>
            </ul>
        </nav>

        <div className="colorlib-footer">
            <p>
                Copyright &copy;
                <script>document.write(new Date().getFullYear());</script> All rights reserved | This site is made with <i className="icon-heart" aria-hidden="true"></i> by @*<a href="https://colorlib.com" target="_blank"></a>*@ <strong>Funky Team</strong>
                <ul>
                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Facebook"><i className="icon-facebook"></i></a></li>
                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Twitter"><i className="icon-twitter"></i></a></li>
                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Instagram"><i className="icon-instagram"></i></a></li>
                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Youtube"><i className="icon-youtube"></i></a></li>
                </ul>
                </p>
        </div>
    </aside>
    <div id="colorlib-main">
          {/* <IdolPersonalInfo/> */}
          {/* <IdolLifeStory/> */}
          {/* <IdolImages/> */}
          <IdolVideos/>
          <FloatingButton/>
          <Footer/>
        </div>               
</div>
);
  }
}

