import React, { Component } from 'react';

export default class IdolImages extends Component {
    render() {
        return (
            <div id="idol_images" className="hero-wrap js-fullheight" data-stellar-background-ratio="0.5">
                <div className="js-fullheight d-flex justify-content-center p-5">
                    			<section className="ftco-section-2 w-100">
                                    <div className="container">
        <div className="isotope_fillter">
            <ul className="gallery_filter list">
                <li className="active" data-filter="*"><a href="#">All</a></li>
                <li data-filter=".brand"><a href="#">Vector</a></li>
                <li data-filter=".manipul"><a href="#">Raster</a></li>
                <li data-filter=".creative"><a href="#">UI/UX</a></li>
                <li data-filter=".design"><a href="#">Printing</a></li>
            </ul>
        </div>
    </div>
				<div className="photograhy">
					<div className="row no-gutters">
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
        style={{backgroundImage: "url(../images/image_1.jpg)"}}>
        </a>
    </div>
    <div className="col-md-4">
        <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
    style={{backgroundImage: "url(../images/image_2.jpg)"}}>
    </a>
</div>
<div className="col-md-4">
    <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_3.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_4.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_5.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_6.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_7.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_8.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_9.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_10.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center"
style={{backgroundImage: "url(../images/image_11.jpg)"}}>
							</a>
						</div>
						<div className="col-md-4">
                            <a href="#" className="photography-entry img d-flex justify-content-center align-items-center" 
style={{backgroundImage: "url(../images/image_12.jpg)"}}>
							</a>
						</div>
					</div>
				</div>
                <div className="more_btn text-center mt-4">
            <a className="main_btn" href="#">Load More Items</a>
            </div>
			</section>
                </div>
            </div>
        );
}
}