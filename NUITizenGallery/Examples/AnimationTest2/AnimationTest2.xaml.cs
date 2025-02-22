/*
 * Copyright(c) 2021 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace NUITizenGallery
{
    public partial class AnimationTest2Page : View
    {
        private Animation animation;
        private float position = 50.0f;

        public AnimationTest2Page()
        {
            InitializeComponent();

            animation = new Animation(2000);
            animation.AnimateTo(imageView, "PositionX", position + 300.0f, 0, 2000);

            image1Btn.Clicked += (o, e) =>
            {
                imageView.PositionX = position;
                animation.Play();
                desc1.Text = "True";
            };

            image2Btn.Clicked += (o, e) =>
            {
                animation.Stop();
                desc1.Text = "False";
            };
        }
    }
}