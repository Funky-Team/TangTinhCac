import React, { Component } from 'react';
import axios from 'axios';

export default class IdolLifeStory extends Component {
    constructor(props) {
        super(props);
        this.state = {
            story: []
        }
    }
    componentWillMount() {
        this.getStoryByIdolId("298aef33-1f11-4c43-8860-e81bea57e16c");
    }
    getStoryByIdolId(id) {
        let thisContext = this;
        axios.get('/api/idolstory/getidolstorybyidolid/' + id)
            .then(function (story) {
                thisContext.setState({
                    ...thisContext.state,
                    story: story.data
                });
                console.log(story);
            }).catch(function (error) {
                console.log(error);
            })
            .finally(function () {
                // always executed
            });
    }
    render() {
        const { story } = this.state;
        console.log("console.log(story);", story);
        return (
            <div id="idol_life_story" className="hero-wrap js-fullheight" data-stellar-background-ratio="0.5">
                <div className="js-fullheight d-flex justify-content-center p-5">
                    <div className="wrapper center-block">
                        <div className="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
                            {story.map(item =>
                                <div className="panel panel-default" id={item.StoryID}>
                                    <div className="panel-heading" role="tab" id={"headingOne" + item.StoryID}>
                                        <h4 className="panel-title">
                                            <a role="button" data-toggle="collapse" data-parent="#accordion" href={"#collapseOne" + item.StoryID} aria-expanded="true" aria-controls={"collapseOne" + item.StoryID}>
                                                {item.StoryTimeline}
                                            </a>
                                        </h4>
                                    </div>
                                    <div id={"collapseOne" + item.StoryID} className="panel-collapse collapse in" role="tabpanel" aria-labelledby={"headingOne" + item.StoryID}>
                                        <div className="panel-body">
                                            {item.StoryContent}
                                        </div>
                                    </div>
                                </div>
                            )}
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

//<div className="panel panel-default">
//    <div className="panel-heading" role="tab" id="headingTwo">
//        <h4 className="panel-title">
//            <a className="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
//                Collapsible Group Item #2
//        </a>
//        </h4>
//    </div>
//    <div id="collapseTwo" className="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
//        <div className="panel-body">
//            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
//      </div>
//    </div>
//</div>
//    <div className="panel panel-default">
//        <div className="panel-heading" role="tab" id="headingThree">
//            <h4 className="panel-title">
//                <a className="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
//                    Collapsible Group Item #3
//        </a>
//            </h4>
//        </div>
//        <div id="collapseThree" className="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
//            <div className="panel-body">
//                Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
//      </div>
//        </div>
//    </div>