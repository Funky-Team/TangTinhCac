import React, { Component } from 'react';
import axios from 'axios';

export default class IdolPersonalInfo extends Component {

    constructor(props) {
        super(props);
        this.state = {
            idol: {}
        };
    }

    componentWillMount() {
        this.getUser("cc596c42-87b6-4e0e-8358-55f544f343c9");
    }

    getUser(id) {
        let thisContext = this;
        axios.get('/api/idol/getidolbyidolid/' + id)
            .then(function (idol) {
                thisContext.setState({
                    ...thisContext.state,
                    idol: idol.data
                });
                console.log(idol);
            })
            .catch(function (error) {
                console.log(error);
            })
            .finally(function () {
                // always executed
            });
    }

    render() {
        const { idol } = this.state;

        return (
            <div id="idol_personal_info" className="hero-wrap js-fullheight" style={{ backgroundImage: "url(../../images/bg_1.jpg)" }}
                data-stellar-background-ratio="0.5">
                <div className="overlay"></div>
                <div className="js-fullheight d-flex justify-content-center align-items-center pt-5 pb-5">
                    <div className="col-xs-12 col-sm-12 col-md-12 col-lg-11 col-xl-11 text">
                        <div className="row d-flex justify-content-around"
                        //style="justify-content:space-around;"
                        >
                            <div className="col-xs-6 col-sm-8 col-md-6 col-lg-6 col-xl-6">
                                <div className="img mb-4 idol-personal-img"
                                    style={{ backgroundImage: "url(https://bestofcomicbooks.com/wp-content/uploads/2019/04/Mia-Khalifa-sexy-busty-pic.jpg)" }} ></div>
                            </div>
                            <div className="col-xs-6 col-sm-8 col-md-6 col-lg-6 col-xl-6 idol-personal-info d-flex justify-content-center">
                                <div className="desc w-100"
                                // style="width:100%;"
                                >
                                    <h2 className="mb-2 text-center font-weight-bold">{idol.IdolName}</h2>
                                    <div className="card weather-card">
                                        <div className="card-body pb-3">
                                            <h6 className="card-title-stretch text-center font-weight-bold bg-primary">Cá nhân</h6>
                                            <table className="table table-borderless mt-2 mb-4">
                                                <tbody>
                                                    <tr>
                                                        <td className="col-left">Fap Danh</td>
                                                        <td>{idol.IdolOtherName == null ? 'N/A' : idol.IdolOtherName}</td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">Năm sản xuất</td>
                                                        <td>{idol.IdolBirthday == null ? 'N/A' : moment(idol.IdolBirthday).format('L')} ({moment(idol.IdolBirthday).diff(moment(), 'years')}) </td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">Xuất xứ</td>
                                                        <td>{idol.IdolCountryCD == null ? 'N/A' : idol.IdolCountryCD}</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <h6 className="card-title-stretch text-center font-weight-bold bg-primary">Nhận dạng</h6>
                                            <table className="table table-borderless mt-2 mb-4">
                                                <tbody>
                                                    <tr>
                                                        <td className="col-left">Chiều cao</td>
                                                        <td>{idol.IdolHeight == null ? 'N/A' : idol.IdolHeight}</td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">Cân nặng</td>
                                                        <td>{idol.IdolWeight == null ? 'N/A' : idol.IdolWeight}</td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">Dáng người</td>
                                                        <td>{idol.BodyID == null ? 'N/A' : idol.BodyID}</td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">V1</td>
                                                        <td>{idol.BoobStatus == null ? 'N/A' : idol.BoobStatus}</td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">Xu-chiêng</td>
                                                        <td>{idol.Bra == null ? 'N/A' : idol.Bra}</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <h6 className="card-title-stretch text-center font-weight-bold bg-primary">Bộ kỹ năng</h6>
                                            <table className="table table-borderless mt-2 mb-4">
                                                <tbody>
                                                    <tr>
                                                        <td className="col-left">Shown</td>
                                                        <td>Topless, Bush, Full frontal, Pink</td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">Solo</td>
                                                        <td>Masturbation, Dildo</td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">Lesbian</td>
                                                        <td>Softcore</td>
                                                    </tr>
                                                    <tr>
                                                        <td className="col-left">Boy/girl</td>
                                                        <td>Blowjob, Vaginal, Creampie</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <h6 className="card-title-stretch text-center font-weight-bold bg-primary">Liên kết</h6>
                                            <div className="idol-social-network d-flex justify-content-center align-item-center">
                                                <ul>
                                                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Facebook"><i className="icon icon-facebook icon-hover"></i></a></li>
                                                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Twitter"><i className="icon icon-twitter icon-hover"></i></a></li>
                                                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Instagram"><i className="icon icon-instagram icon-hover"></i></a></li>
                                                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Pinterest"><i className="icon icon-pinterest icon-hover"></i></a></li>
                                                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Snapchat"><i className="icon icon-snapchat-ghost icon-hover"></i></a></li>
                                                    <li><a href="#" data-toggle="tooltip" data-placement="top" title="Youtube"><i className="icon icon-youtube icon-hover"></i></a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}