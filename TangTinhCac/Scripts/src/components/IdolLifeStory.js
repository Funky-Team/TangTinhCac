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
        $.blockUI();
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
                $.unblockUI();
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
