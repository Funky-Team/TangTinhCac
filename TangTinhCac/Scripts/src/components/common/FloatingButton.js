import React, { Component } from 'react';

export default class FloatingButton extends Component {
    render() {
        return (
            <div className="floating-container">
  <div className="floating-button">+</div>
    <div className="element-container">
      {/* <a href="https://google.com" className="bg-color" target="_blank">
        <span className="float-element tooltip-left a-tag">
            <i className="fab fa-whatsapp"></i>
            <span className="floating-info-container">
              <span className="floating-info">WhatApp</span>
            </span>
        </span>
          </a> */}
        {/* <a href="https://google.com" className="bg-color" target="_blank">
          <span className="float-element a-tag">
            <i className="fa fa-phone"></i>
            <span className="floating-info-container">
              <span className="floating-info">Phone</span>
            </span>
          </span>
        </a> */}
        <a href="https://google.com" className="bg-color" target="_blank">
          <span className="float-element a-tag">
            <i className="icon-home"></i>
            <span className="floating-info-container">
              <span className="floating-info">Trang chủ</span>
            </span>
          </span>
        </a>
        </div>
  </div>
        );
    }
}