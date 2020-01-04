import React, { Component } from 'react';
import {
    BrowserRouter as Router,
    Route,
    Switch,
    Link,
    NavLink
} from 'react-router-dom';

import IdolPersonalInfo from '../components/IdolPersonalInfo';
import IdolLifeStory from '../components/IdolLifeStory';
import IdolImages from '../components/IdolImages';
import IdolVideos from '../components/IdolVideos';
import IdolForum from '../components/IdolForum';
import IdolVoting from '../components/IdolVoting';
import FloatingButton from '../components/common/FloatingButton';
import Footer from '../components/common/Footer';

export default class IdolHome extends Component {
  render() {
    return  (
        <Router>
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
                    <li className="colorlib-active">
                        <NavLink activeClassName="colorlib-active" exact to="/gioithieu">Giới thiệu</NavLink>
                    </li>
                    <li>
                        <NavLink activeClassName="colorlib-active" exact to="/tieusu">Tiếu sử</NavLink>
                    </li>
                    <li>
                        <NavLink activeClassName="colorlib-active" exact to="/hinhanh">Hình ảnh</NavLink>
                    </li>
                    <li>
                        <NavLink activeClassName="colorlib-active" exact to="/video">Video</NavLink>
                    </li>
                    <li>
                        <NavLink activeClassName="colorlib-active" exact to="/diendan">Diễn đàn</NavLink>
                    </li>
                    <li>
                        <NavLink activeClassName="colorlib-active" exact to="/voting">Voting</NavLink>
                    </li>
                    {/* <li className="colorlib-active"><a href="">Giới thiệu</a></li>
                    <li><a href="">Tiếu sử</a></li>
                    <li><a href="">Hình ảnh</a></li>
                    <li><a href="">Video</a></li>
                    <li><a href="">Diễn đàn</a></li>
                    <li><a href="">Voting</a></li> */}
                </ul>
        </nav>

        <div className="colorlib-footer">
            <p>
                Copyright &copy;
                <script>document.write(new Date().getFullYear());</script> All rights reserved | This site is made with <i className="icon-heart" aria-hidden="true"></i> by <strong>Funky Team</strong>
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
          {/* <IdolVideos/> */}
        <Switch>
            <Route exact path="/gioithieu">
                <IdolPersonalInfo />
            </Route>
            <Route path="/tieusu">
                <IdolLifeStory />
            </Route>
            <Route path="/hinhanh">
                <IdolImages />
            </Route>
            <Route path="/video">
                <IdolVideos />
            </Route>
            <Route path="/diendan">
                <IdolForum />
            </Route>
            <Route path="/voting">
                <IdolVoting />
            </Route>
        </Switch>
          <FloatingButton/>
          <Footer/>
        </div>               
</div>
</Router>
);
  }
}

