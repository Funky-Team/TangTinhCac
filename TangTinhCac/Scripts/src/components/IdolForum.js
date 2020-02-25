import React, { Component } from 'react';

export default class IdolForum extends Component {
	render() {
		return (
			<div id="idol_forum" className="hero-wrap js-fullheight" data-stellar-background-ratio="0.5">
				<div className="js-fullheight d-flex justify-content-center p-5">
					<div className="col-md-8">
						<div className="ui-block">
							<div className="news-feed-form">
								<ul className="nav nav-tabs" role="tablist">
									<li className="nav-item">
										<a className="nav-link active inline-items" data-toggle="tab" href="#home-1" role="tab" aria-expanded="true">
											{
												//<svg className="olymp-status-icon"><use href="svg-icons/sprites/icons.svg#olymp-status-icon"></use></svg>
											}
											<i className="icon icon-newspaper-o"></i>
											<span>Status</span>
										</a>
									</li>
									<li className="nav-item">
										<a className="nav-link inline-items" data-toggle="tab" href="#profile-1" role="tab" aria-expanded="false">
											{
												//<svg className="olymp-multimedia-icon"><use href="svg-icons/sprites/icons.svg#olymp-multimedia-icon"></use></svg>
											}
											<i className="icon icon-image"></i>
											<span>Multimedia</span>
										</a>
									</li>
									{
										//<li className="nav-item">
										//	<a className="nav-link inline-items" data-toggle="tab" href="#blog" role="tab" aria-expanded="false">
										//		<svg className="olymp-blog-icon"><use href="svg-icons/sprites/icons.svg#olymp-blog-icon"></use></svg>

										//		<span>Blog Post</span>
										//	</a>
										//</li>
									}
								</ul>
								<div className="tab-content">
									<div className="tab-pane active" id="home-1" role="tabpanel" aria-expanded="true">
										<form>
											<div className="author-thumb">
												<img src="https://www.elleman.vn/wp-content/uploads/2018/01/12/the-rock-elle-man-8.jpg" alt="author" />
											</div>
											<div className="form-group with-icon label-floating is-empty">
												<label className="control-label">Share what you are thinking here...</label>
												<textarea className="form-control" placeholder=""></textarea>
												<span className="material-input"></span>
											</div>
											<div className="add-options-message">
												<button className="btn btn-primary btn-md-2">Post Status</button>
												{
													/*<button className="btn btn-md-2 btn-border-think btn-transparent c-grey">Preview</button>*/
												}
											</div>
										</form>
									</div>
									<div className="tab-pane" id="profile-1" role="tabpanel" aria-expanded="true">
										<form>
											<div className="author-thumb">
												<img src="https://www.elleman.vn/wp-content/uploads/2018/01/12/the-rock-elle-man-8.jpg" alt="author" />
											</div>
											<div className="form-group with-icon label-floating is-empty">
												<label className="control-label">Share what you are thinking here...</label>
												<textarea className="form-control" placeholder=""></textarea>
												<span className="material-input"></span></div>
											<div className="add-options-message">
												<a href="#" className="options-message" data-toggle="tooltip" data-placement="top" data-original-title="ADD PHOTOS">
													<i className="icon icon-camera icon-hover"></i>
												</a>
												<button className="btn btn-primary btn-md-2">Post Status</button>
												{
													/*<button className="btn btn-md-2 btn-border-think btn-transparent c-grey">Preview</button>*/
												}
											</div>
										</form >
									</div >
									{
										/*<div className="tab-pane" id="blog" role="tabpanel" aria-expanded="true">
										<form>
											<div className="author-thumb">
												<img src="https://www.elleman.vn/wp-content/uploads/2018/01/12/the-rock-elle-man-8.jpg" alt="author" />
											</div>
											<div className="form-group with-icon label-floating is-empty">
												<label className="control-label">Share what you are thinking here...</label>
												<textarea className="form-control" placeholder=""></textarea>
												<span className="material-input"></span></div>
											<div className="add-options-message">
												<a href="#" className="options-message" data-toggle="tooltip" data-placement="top" data-original-title="ADD PHOTOS">
													<svg className="olymp-camera-icon" data-toggle="modal" data-target="#update-header-photo"><use href="svg-icons/sprites/icons.svg#olymp-camera-icon"></use></svg>
												</a>
												<a href="#" className="options-message" data-toggle="tooltip" data-placement="top" data-original-title="TAG YOUR FRIENDS">
													<svg className="olymp-computer-icon"><use href="svg-icons/sprites/icons.svg#olymp-computer-icon"></use></svg>
												</a>
												<a href="#" className="options-message" data-toggle="tooltip" data-placement="top" data-original-title="ADD LOCATION">
													<svg className="olymp-small-pin-icon"><use href="svg-icons/sprites/icons.svg#olymp-small-pin-icon"></use></svg>
												</a>
												<button className="btn btn-primary btn-md-2">Post Status</button>
												<button className="btn btn-md-2 btn-border-think btn-transparent c-grey">Preview</button>
											</div>
										</form >
									</div >*/
									}
								</div >
							</div >
						</div >
						<div className="ui-block">
							<article className="hentry post">
								<div className="post__author author vcard inline-items">
									<img src="https://www.elleman.vn/wp-content/uploads/2018/01/12/the-rock-elle-man-8.jpg" alt="author" />
									<div className="author-date">
										<a className="h6 post__author-name fn" href="#">Elaine Dreyfuss</a>
										<div className="post__date">
											<time className="published" datetime="2004-07-24T18:18">
												9 hours ago
									</time>
										</div>
									</div>
									<div className="more"><svg className="olymp-three-dots-icon"><use href="svg-icons/sprites/icons.svg#olymp-three-dots-icon"></use></svg>
										<ul className="more-dropdown">
											<li>
												<a href="#">Edit Post</a>
											</li>
											<li>
												<a href="#">Delete Post</a>
											</li>
											<li>
												<a href="#">Turn Off Notifications</a>
											</li>
											<li>
												<a href="#">Select as Featured</a>
											</li>
										</ul>
									</div>
								</div>
								<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempo incididunt ut
									labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris consequat.
								</p>
								<div className="post-additional-info inline-items">
									<a href="#" className="post-add-icon inline-items">
										<svg className="olymp-heart-icon"><use href="svg-icons/sprites/icons.svg#olymp-heart-icon"></use></svg>
										<span>24</span>
									</a>
									<ul className="friends-harmonic">
										<li>
											<a href="#">
												<img src="img/friend-harmonic7.jpg" alt="friend" />
											</a>
										</li>
										<li>
											<a href="#">
												<img src="img/friend-harmonic8.jpg" alt="friend" />
											</a>
										</li>
										<li>
											<a href="#">
												<img src="img/friend-harmonic9.jpg" alt="friend" />
											</a>
										</li>
										<li>
											<a href="#">
												<img src="img/friend-harmonic10.jpg" alt="friend" />
											</a>
										</li>
										<li>
											<a href="#">
												<img src="img/friend-harmonic11.jpg" alt="friend" />
											</a>
										</li>
									</ul>
									<div className="names-people-likes">
										<a href="#">You</a>, <a href="#">Elaine</a> and
								<br />22 more liked this
							</div>
									<div className="comments-shared">
										<a href="#" className="post-add-icon inline-items">
											<svg className="olymp-speech-balloon-icon"><use href="svg-icons/sprites/icons.svg#olymp-speech-balloon-icon"></use></svg>
											<span>17</span>
										</a>
										<a href="#" className="post-add-icon inline-items">
											<svg className="olymp-share-icon"><use href="svg-icons/sprites/icons.svg#olymp-share-icon"></use></svg>
											<span>24</span>
										</a>
									</div>
								</div>
								{
									/*<div className="control-block-button post-control-button">
										<a href="#" className="btn btn-control">
											<svg className="olymp-like-post-icon"><use href="svg-icons/sprites/icons.svg#olymp-like-post-icon"></use></svg>
										</a>
										<a href="#" className="btn btn-control">
											<svg className="olymp-comments-post-icon"><use href="svg-icons/sprites/icons.svg#olymp-comments-post-icon"></use></svg>
										</a>
										<a href="#" className="btn btn-control">
											<svg className="olymp-share-icon"><use href="svg-icons/sprites/icons.svg#olymp-share-icon"></use></svg>
										</a>
									</div>*/
								}
							</article>
						</div>
						<div className="ui-block">
							<article className="hentry post has-post-thumbnail">
								<div className="post__author author vcard inline-items">
									<img src="https://www.elleman.vn/wp-content/uploads/2018/01/12/the-rock-elle-man-8.jpg" alt="author" />
									<div className="author-date">
										<a className="h6 post__author-name fn" href="#">Green Goo Rock</a>
										<div className="post__date">
											<time className="published" datetime="2004-07-24T18:18">
												March 8 at 6:42pm
									</time>
										</div>
									</div>
									<div className="more"><svg className="olymp-three-dots-icon"><use href="svg-icons/sprites/icons.svg#olymp-three-dots-icon"></use></svg>
										<ul className="more-dropdown">
											<li>
												<a href="#">Edit Post</a>
											</li>
											<li>
												<a href="#">Delete Post</a>
											</li>
											<li>
												<a href="#">Turn Off Notifications</a>
											</li>
											<li>
												<a href="#">Select as Featured</a>
											</li>
										</ul>
									</div>
								</div>
								<p>Hey guys! We are gona be playing this Saturday of <a href="#">The Marina Bar</a> for their new Mystic Deer Party.
									If you wanna hang out and have a really good time, come and join us. We’l be waiting for you!
						</p>
								<div className="post-thumb">
									<img src="https://www.elleman.vn/wp-content/uploads/2018/01/12/the-rock-elle-man-8.jpg" alt="photo" />
								</div>
								<div className="post-additional-info inline-items">

									<a href="#" className="post-add-icon inline-items">
										<svg className="olymp-heart-icon"><use href="svg-icons/sprites/icons.svg#olymp-heart-icon"></use></svg>
										<span>49</span>
									</a>
									<ul className="friends-harmonic">
										<li>
											<a href="#">
												<img src="img/friend-harmonic9.jpg" alt="friend" />
											</a>
										</li>
										<li>
											<a href="#">
												<img src="img/friend-harmonic10.jpg" alt="friend" />
											</a>
										</li>
										<li>
											<a href="#">
												<img src="img/friend-harmonic7.jpg" alt="friend" />
											</a>
										</li>
										<li>
											<a href="#">
												<img src="img/friend-harmonic8.jpg" alt="friend" />
											</a>
										</li>
										<li>
											<a href="#">
												<img src="img/friend-harmonic11.jpg" alt="friend" />
											</a>
										</li>
									</ul>
									<div className="names-people-likes">
										<a href="#">Jimmy</a>, <a href="#">Andrea</a> and
								<br />47 more liked this
							</div>
									<div className="comments-shared">
										<a href="#" className="post-add-icon inline-items">
											<svg className="olymp-speech-balloon-icon"><use href="svg-icons/sprites/icons.svg#olymp-speech-balloon-icon"></use></svg>
											<span>264</span>
										</a>
										<a href="#" className="post-add-icon inline-items">
											<svg className="olymp-share-icon"><use href="svg-icons/sprites/icons.svg#olymp-share-icon"></use></svg>
											<span>37</span>
										</a>
									</div>
								</div>
								{
									/*
									 <div className="control-block-button post-control-button">
									<a href="#" className="btn btn-control">
										<svg className="olymp-like-post-icon"><use href="svg-icons/sprites/icons.svg#olymp-like-post-icon"></use></svg>
									</a>
									<a href="#" className="btn btn-control">
										<svg className="olymp-comments-post-icon"><use href="svg-icons/sprites/icons.svg#olymp-comments-post-icon"></use></svg>
									</a>
									<a href="#" className="btn btn-control">
										<svg className="olymp-share-icon"><use href="svg-icons/sprites/icons.svg#olymp-share-icon"></use></svg>
									</a>
								</div>
									 */
								}
							</article>
						</div>
					</div>
				</div >
			</div >
		);
	}
};